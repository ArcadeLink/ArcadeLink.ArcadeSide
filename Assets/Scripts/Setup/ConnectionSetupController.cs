using DG.Tweening;
using Models;
using ModularMotion;
using TMPro;
using UnityEngine;

namespace Setup
{
    public class ConnectionSetupController : SetupControllerBase
    {
        [SerializeField] private CanvasGroup stepCanvasGroup;
        [SerializeField] private TMP_InputField locationIdInputField, locationKeyInputField;
        [SerializeField] private TMP_InputField leftMachineId, rightMachineId;
        [SerializeField] private UIMotion presetExitMotion, customEnterMotion;

        public override int SetupStep { get; set; } = 1;
        public override bool IsSetupComplete
        {
            get
            {
                return locationIdInputField.text.Length > 0 && locationKeyInputField.text.Length > 0
                                                            && machineSetupModel != null;
            }
        }

        private MachineSetupModel machineSetupModel;
        
        public void OnLeftMachineButtonClicked()
        {
            machineSetupModel = MachineSetupModel.DefaultLeftMachine();
        }
        
        public void OnRightMachineButtonClicked()
        {
            machineSetupModel = MachineSetupModel.DefaultRightMachine();
        }
        
        public void OnBothMachinesButtonClicked()
        {
            machineSetupModel = MachineSetupModel.DefaultBothMachines();
        }
        
        public void OnCustomMachineButtonClicked()
        {
            presetExitMotion.Play();
            customEnterMotion.Play();
        }
        
        private MachineSetupModel customMachineSetupModel = new();
        
        public void OnCustomLeftFieldEdited()
        {
            customMachineSetupModel.leftMachineId = int.Parse(leftMachineId.text);
        }
        
        public void OnCustomRightFieldEdited()
        {
            customMachineSetupModel.rightMachineId = int.Parse(rightMachineId.text);
        }
        
        public void OnCustomMachineConfirmButtonClicked()
        {
            machineSetupModel = customMachineSetupModel;
        }

        public override void StartSetup()
        {
            stepCanvasGroup.DOFade(1, 0.5f);
            stepCanvasGroup.interactable = true;
            stepCanvasGroup.blocksRaycasts = true;
        }

        public override void EndStep()
        {
            SetupSceneController.Instance.Settings.LocationKey = locationKeyInputField.text;
            SetupSceneController.Instance.Settings.LocationId = int.Parse(locationIdInputField.text);
            SetupSceneController.Instance.Settings.MachineSetup = machineSetupModel;
            Debug.Log("Setted location id to: " + locationIdInputField.text);
            Debug.Log("Setted location key to: " + locationKeyInputField.text);
            Debug.Log("Setted machine setup to: " + machineSetupModel.leftMachineId + " " + machineSetupModel.rightMachineId);
            
            stepCanvasGroup.DOFade(0, 0.5f);
            stepCanvasGroup.interactable = false;
            stepCanvasGroup.blocksRaycasts = false;
        }
    }
}