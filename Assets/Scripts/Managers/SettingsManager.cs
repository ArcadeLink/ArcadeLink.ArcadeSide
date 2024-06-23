using System.Collections.Generic;
using System.IO;
using ANU.IngameDebug.Console;
using Models;
using Newtonsoft.Json;
using UnityEngine;

namespace Managers
{
    [DebugCommandPrefix("config")]
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance { get; private set; }
        public readonly List<WebCamDevice> CameraDevices = new();

        private string _settingsPath;

        public SettingsModel Settings
        {
            get
            {
                _settings =
                    JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(_settingsPath));
                return _settings;
            }
            set
            {
                _settings = value;
                File.WriteAllText(_settingsPath, JsonConvert.SerializeObject(_settings));
            }
        }
        
        private SettingsModel _settings;

        private void Awake()
        {
            _settingsPath = $"{Application.persistentDataPath}/settings.json";
            Debug.Log(_settingsPath);
            if (!File.Exists(_settingsPath))
            {
                File.WriteAllText(_settingsPath, JsonConvert.SerializeObject(new SettingsModel()));
            }
            Instance = this;
        }
        
        [DebugCommand("get")]
        public void GetSettings(string key)
        {
            var settings = Settings;
            switch (key)
            {
                case "input":
                    // TODO: Implement input getting logic
                    break;
                case "serial":
                    // TODO: Implement serial getting logic
                    break;
                case "api_addr":
                    Debug.Log(settings.ApiEndpoint);
                    break;
                case "location":
                    Debug.Log($"{settings.LocationId}:{settings.LocationKey}");
                    break;
                case "qiniu_bucket":
                    Debug.Log(settings.BucketName);
                    break;
                case "qiniu_cred":
                    Debug.Log($"{settings.QiniuAk}:{settings.QiniuSk}");
                    break;
                case "file_url":
                    Debug.Log(settings.FileUrl);
                    break;
                case "record_interval":
                    Debug.Log(settings.RecordInterval.ToString());
                    break;
                case "ffmpeg_executable":
                    Debug.Log(settings.FFmpegPath);
                    break;
                case "ffmpeg_hw":
                    // TODO: Implement ffmpeg_hw getting logic
                    break;
                case "all":
                    Debug.Log(JsonConvert.SerializeObject(settings));
                    break;
                default:
                    Debug.Log($"Unknown setting key: {key}");
                    break;
            }
        }
        
        [DebugCommand("set")]
        public void SetSettings(string key, string value)
        {
            var settings = Settings;
            switch (key)
            {
                case "input":
                    // TODO: Implement input setting logic
                    break;
                case "serial":
                    // TODO: Implement serial setting logic
                    break;
                case "api_addr":
                    settings.ApiEndpoint = value;
                    break;
                case "location":
                    var locationParts = value.Split(':');
                    if (locationParts.Length == 2)
                    {
                        settings.LocationId = int.Parse(locationParts[0]);
                        settings.LocationKey = locationParts[1];
                    }
                    break;
                case "qiniu_bucket":
                    settings.BucketName = value;
                    break;
                case "qiniu_cred":
                    var qiniuParts = value.Split(':');
                    if (qiniuParts.Length == 2)
                    {
                        settings.QiniuAk = qiniuParts[0];
                        settings.QiniuSk = qiniuParts[1];
                    }
                    break;
                case "file_url":
                    settings.FileUrl = value;
                    break;
                case "record_interval":
                    settings.RecordInterval = float.Parse(value);
                    break;
                case "ffmpeg_executable":
                    settings.FFmpegPath = value;
                    break;
                case "ffmpeg_hw":
                    // TODO: Implement ffmpeg_hw setting logic
                    break;
                default:
                    Debug.Log($"Unknown setting key: {key}");
                    break;
            }
            Settings = settings;
        }

        [DebugCommand("input")]
        public void OpenInputSettings()
        {
            StateManager.Instance.SetState(States.Setting_Window);
        }
    }
}