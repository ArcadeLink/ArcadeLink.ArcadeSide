using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;
using UnityEngine;

namespace Managers
{
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance { get; private set; }
        public List<WebCamDevice> CameraDevices = new List<WebCamDevice>();

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
    }
}