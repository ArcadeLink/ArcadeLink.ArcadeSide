using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Models;
using Newtonsoft.Json;
using RestEase;
using UnityEngine;
using UnityEngine.Events;

namespace Managers
{
    public class QueueManager : MonoBehaviour
    {
        public static QueueManager Instance { get; private set; }

        public List<QueueItem> QueueItems
        {
            get => queueItems;
            private set
            {
                queueItems = value;
                OnQueueItemsUpdated.Invoke();
            }
        }

        private List<QueueItem> queueItems = new List<QueueItem>();

        public UnityEvent OnQueueItemsUpdated = new();
        
        public UnityEvent OnLeftPassed = new();
        public UnityEvent OnRightPassed = new();
        

        public async Task UpdateQueueItems()
        {
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            
            var queueModel = SettingsManager.Instance.Settings.MachineSetup;

            var newQueueItems = new List<QueueItem>();
            
            if (queueModel.leftMachineId != -1)
            {
                var resultLeft = await api.GetQueue(
                    SettingsManager.Instance.Settings.LocationId, 
                    SettingsManager.Instance.Settings.MachineSetup.leftMachineId);
                var rawDataLeft = JsonConvert.SerializeObject(resultLeft.data);
                var queueItemsLeft = JsonConvert.DeserializeObject<List<QueueItem>>(rawDataLeft);
                newQueueItems.AddRange(queueItemsLeft);
            }

            if (queueModel.rightMachineId != -1)
            {
                var resultRight = await api.GetQueue(
                    SettingsManager.Instance.Settings.LocationId,
                    SettingsManager.Instance.Settings.MachineSetup.rightMachineId);
                var rawDataRight = JsonConvert.SerializeObject(resultRight.data);
                var queueItemsRight = JsonConvert.DeserializeObject<List<QueueItem>>(rawDataRight);
                newQueueItems.AddRange(queueItemsRight);
            }
            
            QueueItems = newQueueItems;
        }

        public async Task InsertQueueItem(bool isRight, string userId)
        {
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            var secret = SettingsManager.Instance.Settings.LocationKey;
            //SettingsManager.Instance.Settings.LocationId, userId, isRight ? 1 : 0
            await api.PostQueue(new HttpRequestModels.QueueInsertRequest()
            {
                deviceId = GetCurrentMachineId(isRight),
                locationId = SettingsManager.Instance.Settings.LocationId,
                userId = userId
            }, secret);
        }
        
        public async Task PassQueueItem(bool isRight)
        {
            var item = QueueItems.First(a => a.machineId == GetCurrentMachineId(isRight));
            var userId = item.userId;
            var queueId = item.queueId;
            var secret = SettingsManager.Instance.Settings.LocationKey;
            
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            await api.PassQueue(new HttpRequestModels.QueueDeleteRequest()
            {
                deviceId = GetCurrentMachineId(isRight),
                locationId = SettingsManager.Instance.Settings.LocationId,
                queueId = queueId
            },secret);

            if (isRight)
            {
                // 返回过号后的下一位
                OnRightPassed.Invoke();
            }
            else
            {
                OnLeftPassed.Invoke();
            }
            
            await UpdateQueueItems();
        }
        
        public QueueItem GetNextQueueItem(bool isRight)
        {
            var item = QueueItems.First(a => a.machineId == GetCurrentMachineId(isRight));
            return item;
        }

        private int GetCurrentMachineId(bool isRight)
        {
            var leftMachineId = SettingsManager.Instance.Settings.MachineSetup.leftMachineId;
            var rightMachineId = SettingsManager.Instance.Settings.MachineSetup.rightMachineId;
            var currentMachineId = isRight ? rightMachineId : leftMachineId;
            return currentMachineId;
        }
        
        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            InvokeRepeating(nameof(UpdateQueueItems), 0, 10);
        }
    }
}