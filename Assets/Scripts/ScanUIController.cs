using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Interfaces;
using Managers;
using Models;
using ModularMotion;
using Newtonsoft.Json;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;
using OtpNet;
using RestEase;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScanUIController : MonoBehaviour
{
    [SerializeField]
    private RawImage cameraPreviewRawImage;
    [SerializeField]
    private TMP_Text qrErrorText;
    [SerializeField]
    private UIMotion loadingMotion;
    
    private WebCamTexture webCamTexture;
    private void Start()
    {
        Debug.Log("Scan UI Controller started");
        
        // Get current camera device texture
        webCamTexture = ScanManager.Instance.GetWebCamTexture();
        cameraPreviewRawImage.texture = webCamTexture;
        webCamTexture.Play();
        
        Debug.Log("Camera preview started");
        
        // Start QR code scanning
        isReadyToScan = true;
    }

    private float timer;
    private bool isReadyToScan;
    private void Update()
    {
        if (!isReadyToScan) return;
        
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            timer = 0;
            Debug.Log("Scanning QR code...");
            ScanQRCode();
        }
    }
    
    private void OnDestroy()
    {
        webCamTexture.Stop();
    }


    private void ScanQRCode()
    {
        // 1.截图
        var texture2D = new Texture2D(webCamTexture.width, webCamTexture.height);
        texture2D.SetPixels(webCamTexture.GetPixels());
        texture2D.Apply();
        

        // 2.使用OpenCV进行二维码识别
        var img = new Mat(webCamTexture.height, webCamTexture.width, CvType.CV_8UC3);
        OpenCVForUnity.UnityUtils.Utils.texture2DToMat(texture2D, img);
        
        var points = new Mat();
        
        // detector
        var qrCodeDetector = new QRCodeDetector();
        
        var qrCodeFound = qrCodeDetector.detect(img, points);
        var fallback = new Mat();

        if (qrCodeFound)
        {
            qrErrorText.text = "二维码识别成功";
            var qrCodeData = qrCodeDetector.decode(img, points, fallback);
            HandleResult(result: qrCodeData);
        }
        else
        {
            qrErrorText.text = "请将二维码放入扫描框内";
        }
        
        // 释放资源
        img.Dispose();
        points.Dispose();
        fallback.Dispose();
        Destroy(texture2D);
    }

    private async void HandleResult(string result)
    {
        var progressBar = FindObjectOfType<TimeoutProgressBar>();

        progressBar.ResetTimer();
        if (!result.StartsWith("aircade://"))
        {
            qrErrorText.text = "无效的二维码格式";
            await ModalController.Instance.ShowModal("错误", "无效的二维码\n这不是一个 Aircade 二维码", 2f);
            return;
        }
        
        var uri = new Uri(result);
        // airacde://intent?uid=xxx&code=123456
        var intent = uri.Host;
        var query = HttpUtility.ParseQueryString(uri.Query);
        var uid = query["uid"];
        var code = query["code"];

        isReadyToScan = false;
        progressBar.PauseTimer();
        loadingMotion.PlayAllForward();
        
        Debug.Log($"Intent: {intent}, UID: {uid}, Code: {code} at {DateTime.UtcNow}");
        
        if (!await VerifyIntent(uid, code))
        {
            await ModalController.Instance.ShowModal("错误", "无效的二维码\n这个二维码已经过期了", 2f);
            isReadyToScan = true;
            progressBar.ResumeTimer();
            loadingMotion.PlayAllBackward();
            return;
        }

        Debug.Log("Intent verified");

        var isForRecord = FeatureFlagManager.IsScanForceRecordEnabled();
        if (isForRecord) intent = "record";
        
        switch (intent)
        {
            case "static":
                qrErrorText.text = string.Empty;
                ScanManager.Instance.currentIntent = new QrIntent
                {
                    Intent = Intents.static_card,
                    UserId = uid,
                };
                StateManager.Instance.SetState(States.Static_Window);
                break;
            case "record":
                if (FeatureFlagManager.IsFeatureEnabled("record"))
                {
                    qrErrorText.text = string.Empty;
                    var recordIntent =  new QrIntent
                    {
                        Intent = Intents.record,
                        UserId = uid,
                    };
                    ScanManager.Instance.currentIntent = recordIntent;
                    ScanManager.Instance.currentRecordIntent = recordIntent;
                    RecordManager.Instance.StartRecord();
                    StateManager.Instance.SetState(States.Main_Window);
                    return;
                }
                
                qrErrorText.text = "录像功能暂时不可用";
                isReadyToScan = true;
                progressBar.ResumeTimer();
                loadingMotion.PlayAllBackward();
                break;
            case "queue":
                qrErrorText.text = string.Empty;
                ScanManager.Instance.currentIntent = new QrIntent
                {
                    Intent = Intents.scan,
                    UserId = uid,
                };
                StateManager.Instance.SetState(States.Join_Window);
                break;
        }
    }
    
    private async Task<bool> VerifyIntent(string userId, string code)
    {
        try
        {
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            var secret = SettingsManager.Instance.Settings.LocationKey;
            Debug.Log(
                $"Verifying user {userId} intent as {SettingsManager.Instance.Settings.LocationId} with secret: {secret} at {api}");
            var userSecretResp = await api.GetUserSecret(userId, SettingsManager.Instance.Settings.LocationId,
                secret);
            Debug.Log(JsonConvert.SerializeObject(userSecretResp));
            var userSecret = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                JsonConvert.SerializeObject(userSecretResp.data))["otp_secret"];

            // 验证用户身份
            var encodedSecret = Base32Encoding.ToBytes(userSecret);
            var otp = new Totp(encodedSecret, totpSize: 8);
            var isValid = otp.VerifyTotp(DateTime.UtcNow, code, out _, new VerificationWindow(2, 2));

            return isValid;
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogError(e);
            return false;
        }
    }
}