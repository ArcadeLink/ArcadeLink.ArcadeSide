using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Setup
{
    public class ServerSetupController : SetupControllerBase
    {
        [SerializeField]
        private CanvasGroup stepCanvasGroup;
        [SerializeField] private TMP_InputField serverAddressInputField;

        public override int SetupStep { get; set; } = 0;
        public override bool IsSetupComplete
        {
            get
            {
                return serverAddressInputField.text.Length > 0 && serverAddressInputField.text.Contains("https://");
            }
        }

        public override void StartSetup()
        {
            stepCanvasGroup.DOFade(1, 0.5f);
            stepCanvasGroup.interactable = true;
            stepCanvasGroup.blocksRaycasts = true;
        }
        
        public void OnOfficialServerButtonClicked()
        {
            serverAddressInputField.text = "https://api.arcade-link.top";
        }

        public override void EndStep()
        {
            SetupSceneController.Instance.Settings.ApiEndpoint = serverAddressInputField.text;
            Debug.Log("Setted server address to: " + serverAddressInputField.text);
            
            stepCanvasGroup.DOFade(0, 0.5f);
            stepCanvasGroup.interactable = false;
            stepCanvasGroup.blocksRaycasts = false;
        }
    }
}