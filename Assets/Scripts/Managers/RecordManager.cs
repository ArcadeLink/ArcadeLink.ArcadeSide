using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using FFMpegCore;
using FFMpegCore.Enums;
using Models;
using OBSWebsocketDotNet;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class RecordManager : MonoBehaviour
    {
        public static RecordManager Instance { get; private set; }
        
        private bool IsRecordEnabled { get; set; }

        private readonly OBSWebsocket Client = new OBSWebsocket();
        
        private bool isRecording, isConnected;

        private float recordTimer;

        private void Awake()
        {
            Instance = this;
            IsRecordEnabled = FeatureFlagManager.IsFeatureEnabled("record");

            // 初始化OBS客户端
            if (isActiveAndEnabled && IsRecordEnabled)
            {
                Client.Connected += delegate { Debug.Log("Connected to OBS."); isConnected = true;};
                Client.Disconnected += delegate { Debug.Log("Disconnected from OBS."); isConnected = false;};

                Client.ConnectAsync("ws://127.0.01:4455", "");
            }
        }

        private async Task ConvertVideo(string videoPath, string outputPath)
        {
            GlobalFFOptions.Configure(new FFOptions()
            {
                BinaryFolder = SettingsManager.Instance.Settings.FFmpegPath
            });
            
            var ffmpegArguments = FFMpegArguments.FromFileInput(videoPath, true)
                .OutputToFile(outputPath, true, options => options
                    .WithVideoCodec(VideoCodec.LibX264)
                    .WithFastStart()
                );
            
            await ffmpegArguments.ProcessAsynchronously();
            
            Debug.Log("Video converted.");
        }
        
        
        public async void StartRecord()
        {
            if (!IsRecordEnabled)
            {
                Debug.Log("Record feature is disabled.");
                return;
            }

            if (isRecording)
            {
                Debug.Log("Recording already started.");
            }
            else
            {
                BottomBarController.Instance.SetRecordStatus(RecordStatus.Pending);

                await InitializeObs();
                recordTimer = SettingsManager.Instance.Settings.RecordInterval;
                
                Debug.Log("Recording started.");
            }
        }

        private async UniTask StopRecord()
        {
            if (!IsRecordEnabled)
            {
                Debug.Log("Record feature is disabled.");
                return;
            }

            if (!isRecording)
            {
                Debug.Log("Recording already stopped.");
            }
            else
            {
                isRecording = false;
                BottomBarController.Instance.SetRecordStatus(RecordStatus.Pending);
                await ResetObs();
                await ConvertVideo(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/UploadingVideos/{ScanManager.Instance.currentRecordIntent.UserId}.mkv",
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/UploadingVideos/{ScanManager.Instance.currentRecordIntent.UserId}.mp4");
                await UploadFile();
                BottomBarController.Instance.SetRecordStatus(RecordStatus.Stopped);
                Debug.Log("Recording stopped.");
            }
        }

        private async UniTask ResetObs()
        {
            var intent = ScanManager.Instance.currentRecordIntent;
            
            // 停止录制
            if (Client.GetRecordStatus().IsRecording)
            {
                Client.StopRecord();
            }
            else
            {
                return;
            }
        
            // 等待OBS处理 (5s)
            await UniTask.Delay(5000);

            // 获取文件
            var path = Client.GetRecordDirectory();
            var files = Directory.GetFiles(path);
            Debug.Log("Remain files: " + files.Length);

            // 上次文件没有清空的情况
            if (files.Length != 1)
            {
                Debug.LogWarning("Record file not found.");
                return;
            }
            
            // 移动文件
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/UploadingVideos");
            File.Copy(files[0],
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/UploadingVideos/{ScanManager.Instance.currentRecordIntent.UserId}.mkv",
                true);

        }

        private async UniTask UploadFile()
        {
            Debug.Log("Start Uploading...");
            // 上传文件
            await UploadService.Upload(
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/UploadingVideos/{ScanManager.Instance.currentRecordIntent.UserId}.mp4",
                ScanManager.Instance.currentRecordIntent.UserId);
            
            // 重置状态
            ScanManager.Instance.currentRecordIntent = null;
            isRecording = false;
        }


        private async UniTask InitializeObs()
        {
            // Initialize OBS
            if (!isConnected)
            {
                Debug.Log("Not connected to OBS.");
                await ModalController.Instance.ShowModal("录制失败", "OBS未连接, 请询问此店铺是否已开启录制功能");
                return;
            }
            
            // 等等OBS准备 (3s)
            await UniTask.Delay(3000);
            
            // 检查是否正在录制
            if (Client.GetRecordStatus().IsRecording)
            {
                Debug.Log("Recording already started. Stopping.");
                Client.StopRecord();
                return;
            }

            // 删除上次录制的文件
            var recordDirectory = Client.GetRecordDirectory();
            if (Directory.GetFiles(recordDirectory).Length > 0)
            {
                foreach (var file in Directory.GetFiles(recordDirectory))
                {
                    File.Delete(file);
                }
            }
            
            // 开始录制
            BottomBarController.Instance.SetRecordStatus(RecordStatus.Recording, SettingsManager.Instance.Settings.RecordInterval);

            Client.StartRecord();
            isRecording = true;
        }


        private async void Update()
        {
            if (!isRecording) return;
            
            recordTimer -= Time.deltaTime;
            
            if (recordTimer <= 0)
            {
                await StopRecord();
            }
        }
    }
}