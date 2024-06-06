using System;
using Models;
using UnityEngine;

namespace Managers
{
    public class ScanManager : MonoBehaviour
    {
        public static ScanManager Instance { get; private set; }
        
        public QrIntent currentIntent;
        public QrIntent currentRecordIntent;
        
        private int cameraDeviceIndex;
        private WebCamTexture webCamTexture;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            // Get all available camera devices
            var devices = WebCamTexture.devices;
            foreach (var device in devices)
            {
                Debug.Log("Camera device: " + device.name);
                SettingsManager.Instance.CameraDevices.Add(device);
            }

            cameraDeviceIndex =
                SettingsManager.Instance.Settings.CameraDevice >= devices.Length
                    ? 0
                    : SettingsManager.Instance.Settings.CameraDevice;

            webCamTexture = new WebCamTexture(devices[cameraDeviceIndex].name);
        }
        
        public WebCamTexture GetWebCamTexture()
        {
            return webCamTexture;
        }
    }
}