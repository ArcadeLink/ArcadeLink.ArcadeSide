using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Models;
using Newtonsoft.Json;
using RestEase;
using UnityEngine;

namespace Managers
{
    public class AdManager : MonoBehaviour
    {
        public static AdManager Instance { get; private set; }
        
        public List<AdModel> Ads = new List<AdModel>();


        private void Awake()
        {
            Instance = this;
        }

        private async void Start()
        {
            await LoadAds();
        }

        private async Task LoadAds()
        {
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            Debug.Log(SettingsManager.Instance.Settings.ApiEndpoint);
            var docs = await api.GetAnnouncements();
            Debug.Log(docs.data.ToString());
            var ads = JsonConvert.DeserializeObject<AdModel[]>(
                JsonConvert.SerializeObject(docs.data));
            Ads = ads.ToList();
        }
    }
}