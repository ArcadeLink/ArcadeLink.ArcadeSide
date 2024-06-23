using System;
using System.Globalization;
using Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUIController : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown cameraDropdown, inputMethodDropdown;
    [SerializeField]
    private RawImage cameraPreviewRawImage;

    private void Start()
    {
        var settings = SettingsManager.Instance.Settings;
        cameraDropdown.value = settings.CameraDevice;
        var devices = WebCamTexture.devices;
        foreach (var device in devices)
        {
            cameraDropdown.options.Add(new TMP_Dropdown.OptionData(device.name));
        }
        cameraDropdown.RefreshShownValue();
        cameraDropdown.onValueChanged.AddListener(index =>
        {
            settings.CameraDevice = index;
            SettingsManager.Instance.Settings = settings;
            var webCamTexture = new WebCamTexture(devices[index].name);
            cameraPreviewRawImage.texture = webCamTexture;
            webCamTexture.Play();
        });
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
        if (Input.GetKeyDown(KeyCode.F2))
        {
            StateManager.Instance.SetState(States.Main_Window);
        }
    }
}