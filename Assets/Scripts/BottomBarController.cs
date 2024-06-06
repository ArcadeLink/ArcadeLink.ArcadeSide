using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using LeTai.TrueShadow;
using Managers;
using Models;
using ModularMotion;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BottomBarController : MonoBehaviour
{
    [SerializeField] private TMP_Text leftQueueText, rightQueueText, versionCodeText, workingModeText;
    [SerializeField] private UIMotion leftQueueMotion, rightQueueMotion;
    
    [SerializeField] private TMP_Text recordStatusText;
    [SerializeField] private Image recordStatusLight;
    
    [SerializeField] private Color recordColor, notRecordColor, pendingColor, progressBarColor;
    [SerializeField] private Image recordProgressImage;
    
    public RecordStatus currentRecordStatus;
    
    public static BottomBarController Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void GoSettingsState()
    {
        StateManager.Instance.SetState(States.Setting_Window);
    }
    
    private void Start()
    {
        leftQueueText.text = "左机 0 人";
        rightQueueText.text = "右机 0 人";
        
        versionCodeText.text = "0.0.1";
        workingModeText.text = "正常模式";
        
        recordStatusText.text = "未录制";
        recordStatusLight.color = notRecordColor;
        recordStatusLight.GetComponent<TrueShadow>().Color = notRecordColor;

        var setup = SettingsManager.Instance.Settings.MachineSetup;
        if (setup.leftMachineId != -1)
        {
            leftQueueMotion.PlayAll();
        }
        if (setup.rightMachineId != -1)
        {
            rightQueueMotion.PlayAll();
        }
        
    }
    
    public void SetRecordStatus(RecordStatus status, float time = 0f)
    {
        switch (status)
        {
            case RecordStatus.Pending:
                recordStatusText.text = "处理中";
                recordStatusLight.color = pendingColor;
                recordStatusLight.GetComponent<TrueShadow>().Color = pendingColor;
                recordProgressImage.DOFillAmount(1, 0.2f);
                recordProgressImage.DOColor(pendingColor, 0.2f);
                recordProgressImage.GetComponent<TrueShadow>().Color = pendingColor;
                break;
            case RecordStatus.Recording:
                recordStatusText.text = "录制中";
                recordStatusLight.color = recordColor; 
                recordStatusLight.GetComponent<TrueShadow>().Color = recordColor;
                recordProgressImage.fillAmount = 1;
                recordProgressImage.DOFillAmount(0, time);
                recordProgressImage.DOColor(progressBarColor, 0.2f);
                recordProgressImage.GetComponent<TrueShadow>().Color = progressBarColor;
                break;
            case RecordStatus.Stopped:
                recordStatusText.text = "未录制";
                recordStatusLight.color = notRecordColor;
                recordStatusLight.GetComponent<TrueShadow>().Color = notRecordColor;
                recordProgressImage.DOFillAmount(0, 0.2f);
                break;
        }
        
        currentRecordStatus = status;
    }

    private async void Update()
    {
        if (Input.GetButtonDown("QueueLeft"))
        {
            if (StateManager.Instance.CurrentState != States.Join_Window)
            {
                // Pass current player in queue
                await QueueManager.Instance.PassQueueItem(false);
                await ModalController.Instance.ShowModal("成功", "左侧队列的玩家已过号一位", 1f);
            }
        }
        
        if (Input.GetButtonDown("QueueRight"))
        {
            if (StateManager.Instance.CurrentState != States.Join_Window)
            {
                // Pass current player in queue
                await QueueManager.Instance.PassQueueItem(true);
                await ModalController.Instance.ShowModal("成功", "右侧队列的玩家已过号一位", 1f);
            }
        }
    }
}
