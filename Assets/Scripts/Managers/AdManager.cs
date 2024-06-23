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
            var docs = await api.GetAnnouncements();
            var ads = JsonConvert.DeserializeObject<AdModel[]>(
                JsonConvert.SerializeObject(docs.data));
            var adModels = ads.ToList();
            Ads = adModels.Where(a =>
                    a.location == SettingsManager.Instance.Settings.LocationId.ToString() | a.location == "0")
                .ToList();
        }
    }
}