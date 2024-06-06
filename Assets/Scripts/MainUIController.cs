using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Managers;
using ModularMotion;
using UnityEngine;

public class MainUIController : MonoBehaviour
{
    [SerializeField]
    private Transform LeftQueueListContainer, RightQueueListContainer;
    
    // Frame0: Hide
    // Frame1: Side
    // Frame2: Filled
    [SerializeField]
    private UIMotion LeftQueueListMotion, RightQueueListMotion;
    
    [SerializeField]
    private GameObject QueueListItemPrefab;
    
    private async void Start()
    {
        Debug.Log("MainUIController Start");

        // get queue model
        var queueModel = SettingsManager.Instance.Settings.MachineSetup;
        var leftMachineEnable = queueModel.leftMachineId != -1;
        var rightMachineEnable = queueModel.rightMachineId != -1;

        if (leftMachineEnable && rightMachineEnable)
        {
            LeftQueueListMotion.PlayNext();
            RightQueueListMotion.PlayNext();
        }
        else if (leftMachineEnable)
        {
            LeftQueueListMotion.PlayAll();
        }
        else if (rightMachineEnable)
        {
            RightQueueListMotion.PlayAll();
        }
        
        await QueueManager.Instance.UpdateQueueItems();
        
        foreach (var queueItem in QueueManager.Instance.QueueItems)
        {
            Debug.Log($"Queue item: {queueItem.nickname} with card {queueItem.cardUrl}" );
            
            var queueItemGameObject = Instantiate(QueueListItemPrefab,
                queueItem.machineId == 1 ? RightQueueListContainer : LeftQueueListContainer);
            await queueItemGameObject.GetComponent<QueueListItem>().SetQueueItem(queueItem);
        }
        
        QueueManager.Instance.OnQueueItemsUpdated.AddListener(UpdateUI);
    }
    
    private int UpdateUIEventCount = 0;
    private bool isUpdatingUI = false;

    private void UpdateUI()
    {
        UpdateUIEventCount++;
        Debug.Log($"UpdateUIEventCount: {UpdateUIEventCount}");
    }

    private async void Update()
    {
        if (UpdateUIEventCount > 0 && !isUpdatingUI)
        {
            isUpdatingUI = true;
            await UpdateUIWithQueue();
            UpdateUIEventCount--;
            isUpdatingUI = false;
        }
    }

    private async Task UpdateUIWithQueue()
    {
        var newQueueItems = QueueManager.Instance.QueueItems;

        // Get all QueueListItem components in the scene
        var queueItemsInUI = GameObject.FindObjectsOfType<QueueListItem>();

        // Update existing items and add new items
        foreach (var queueItem in newQueueItems)
        {
            var existingItem = queueItemsInUI.FirstOrDefault(item => item.QueueId == queueItem.queueId);
            if (existingItem != null)
            {
                // Update existing item
                await existingItem.SetQueueItem(queueItem);
            }
            else
            {
                // Add new item
                var queueItemGameObject = Instantiate(QueueListItemPrefab,
                    queueItem.machineId ==
                    SettingsManager.Instance.Settings.MachineSetup.rightMachineId 
                        ? RightQueueListContainer 
                        : LeftQueueListContainer);
                
                await queueItemGameObject.GetComponent<QueueListItem>().SetQueueItem(queueItem);
            }
        }

        // Remove items that no longer exist
        foreach (var queueItemInUI in queueItemsInUI)
        {
            if (newQueueItems.All(item => item.queueId != queueItemInUI.QueueId))
            {
                // Play animation and then destroy
                var uiMotion = queueItemInUI.GetComponent<CanvasGroup>();
                if (uiMotion != null)
                {
                    uiMotion.DOFade(0, 0.5f).onComplete 
                        += () => Destroy(queueItemInUI.gameObject);
                }
            }
        }
    }
}