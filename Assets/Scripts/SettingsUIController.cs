using System;
using System.Globalization;
using Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUIController : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField locationIdInputField, locationKeyInputField, apiEndpointInputField,
        qiniuAccessKeyInputField, qiniuSecretKeyInputField, qiniuBucketInputField, qiniuDomainInputField, recordIntervalInputField,
            ffmpegBinaryPathInputField, ffmpegTempPathInputField;
    [SerializeField]
    private TMP_Dropdown cameraDropdown;
    [SerializeField]
    private Toggle maintanceModeToggle;
    [SerializeField]
    private RawImage cameraPreviewRawImage;
    
    public void OnSaveButtonClicked()
    {
        var settings = SettingsManager.Instance.Settings;
        settings.ApiEndpoint = apiEndpointInputField.text;
        settings.LocationId = Convert.ToInt32(locationIdInputField.text);
        settings.LocationKey = locationKeyInputField.text;
        settings.CameraDevice = cameraDropdown.value;
        settings.BucketName = qiniuBucketInputField.text;
        settings.QiniuAk = qiniuAccessKeyInputField.text;
        settings.QiniuSk = qiniuSecretKeyInputField.text;
        settings.FileUrl = qiniuDomainInputField.text;
        settings.MaintainceMode = maintanceModeToggle.isOn;
        settings.RecordInterval = float.Parse(recordIntervalInputField.text);
        settings.FFmpegPath = ffmpegBinaryPathInputField.text;
        settings.FFmpegTempPath = ffmpegTempPathInputField.text;
        
        SettingsManager.Instance.Settings = settings;

        OnBackButtonClicked();
    }

    private void Start()
    {
        var settings = SettingsManager.Instance.Settings;
        locationIdInputField.text = settings.LocationId.ToString();
        locationKeyInputField.text = settings.LocationKey;
        cameraDropdown.value = settings.CameraDevice;
        qiniuBucketInputField.text = settings.BucketName;
        qiniuAccessKeyInputField.text = settings.QiniuAk;
        qiniuSecretKeyInputField.text = settings.QiniuSk;
        qiniuDomainInputField.text = settings.FileUrl;
        apiEndpointInputField.text = settings.ApiEndpoint;
        maintanceModeToggle.isOn = settings.MaintainceMode;
        recordIntervalInputField.text = settings.RecordInterval.ToString(CultureInfo.InvariantCulture);
        ffmpegBinaryPathInputField.text = settings.FFmpegPath;
        ffmpegTempPathInputField.text = settings.FFmpegTempPath;
        
        var devices = WebCamTexture.devices;
        foreach (var device in devices)
        {
            cameraDropdown.options.Add(new TMP_Dropdown.OptionData(device.name));
        }
        
        cameraDropdown.RefreshShownValue();
        
        var webCamTexture = new WebCamTexture(devices[settings.CameraDevice].name);
        cameraPreviewRawImage.texture = webCamTexture;
        webCamTexture.Play();
    }

    private void OnDestroy()
    {
        var webCamTexture = cameraPreviewRawImage.texture as WebCamTexture;
        webCamTexture!.Stop();
    }

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            OnSaveButtonClicked();
        }
    }

    private void OnBackButtonClicked()
    {
        StateManager.Instance.SetState(States.Main_Window);
    }
}