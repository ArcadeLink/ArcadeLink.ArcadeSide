using System;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Managers;
using ModularMotion;
using TMPro;
using UnityEngine;

public class JoinUIController : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("JoinUIController Start");
        timeoutProgressBar = FindObjectOfType<TimeoutProgressBar>();
    }

    private bool isSelected;
    private TimeoutProgressBar timeoutProgressBar;
    
    [SerializeField]
    private UIMotion leftJoinMotion, rightJoinMotion;
    [SerializeField]
    private TMP_Text leftJoinText, rightJoinText;
    [SerializeField]
    private CanvasGroup leftLoadingAnimation, rightLoadingAnimation;
    [SerializeField]
    private CanvasGroup leftFinishedAnimation, rightFinishedAnimation;
    
    private async void Update()
    {
        if (isSelected)
        {
            return;
        }
        
        if (Input.GetButton("QueueLeft"))
        {
            timeoutProgressBar.PauseTimer();
            isSelected = true;

            if (SettingsManager.Instance.Settings.MachineSetup.leftMachineId == -1)
            {
                await ModalController.Instance.ShowModal("错误", "左侧机器未启用, 请联系管理员");
                timeoutProgressBar.ResumeTimer();
                isSelected = false;
                return;
            }
            
            leftJoinMotion.PlayNext();
            leftJoinText.text = "加入中";
            leftLoadingAnimation.DOFade(1, 0.5f);
            
            try
            {
                await QueueManager.Instance.InsertQueueItem(false, ScanManager.Instance.currentIntent.UserId);
                await QueueManager.Instance.UpdateQueueItems();
            }
            catch (Exception e)
            {
                Debug.Log(e);
                await ModalController.Instance.ShowModal("错误", $"加入队列失败, 请检查是否已经在队列中\n{e.Message}");
                leftJoinMotion.PlayAllBackward();
                StateManager.Instance.SetState(States.Main_Window);
                leftLoadingAnimation.DOFade(0, 0.5f);
            }
            
            leftJoinMotion.PlayNext();
            leftJoinText.text = "已加入";
            leftLoadingAnimation.DOFade(0, 0.5f);
            leftFinishedAnimation.DOFade(1, 0.5f);

            await UniTask.WaitForSeconds(1);
            isSelected = true;
            
            StateManager.Instance.SetState(States.Main_Window);
        }
        
        if (Input.GetButton("QueueRight"))
        {
            timeoutProgressBar.PauseTimer();
            isSelected = true;
            
            if (SettingsManager.Instance.Settings.MachineSetup.rightMachineId == -1)
            {
                await ModalController.Instance.ShowModal("错误", "右侧机器未启用, 请联系管理员");
                timeoutProgressBar.ResumeTimer();
                isSelected = false;
                return;
            }
            
            rightJoinMotion.PlayNext();
            rightJoinText.text = "加入中";
            rightLoadingAnimation.DOFade(1, 0.5f);

            
            try
            {
                await QueueManager.Instance.InsertQueueItem(true, ScanManager.Instance.currentIntent.UserId);
                await QueueManager.Instance.UpdateQueueItems();
            }
            catch (Exception e)
            {
                Debug.Log(e);
                await ModalController.Instance.ShowModal("错误", $"加入队列失败, 请检查是否已经在队列中\n{e.Message}");
                StateManager.Instance.SetState(States.Main_Window);
                rightJoinMotion.PlayAllBackward();
                rightLoadingAnimation.DOFade(0, 0.5f);
            }
            
            rightJoinMotion.PlayNext();
            rightJoinText.text = "已加入";
            rightLoadingAnimation.DOFade(0, 0.5f);
            rightFinishedAnimation.DOFade(1, 0.5f);

            
            await UniTask.WaitForSeconds(1);
            isSelected = true;
            
            StateManager.Instance.SetState(States.Main_Window);
        }
    }
}