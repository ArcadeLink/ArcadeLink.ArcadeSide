using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Managers;
using Models;
using ModularMotion;
using TMPro;
using UnityEngine;

public class AdWidgetLoader : MonoBehaviour
{
    [SerializeField] private TMP_Text adTitle, adContent;
    [SerializeField] private UIMotion adLoadFinishMotion;
    
    private bool isAdLoaded = false;
    
    private async void Start()
    {
        StartCoroutine(ShowAds());

        await UniTask.WaitUntil(() => isAdLoaded);
        adLoadFinishMotion.Play();
    }

    private void Update()
    {
        // 未加载广告则不显示
        if (AdManager.Instance.Ads.Count == 0) return;
        
        // 每隔5秒切换一次广告
        adTimer += Time.deltaTime;
        if (!(adTimer >= 5)) return;
        adTimer = 0;
        StartCoroutine(ShowAds());
        isAdLoaded = true;
    }

    private int currentAdIndex = 0;
    private float adTimer = 0;
    private IEnumerator ShowAds()
    {
        if (AdManager.Instance.Ads.Count == 0)
        {
            Debug.Log("No ads available. Aborting...");
            yield break;
        }
        
        if (currentAdIndex >= AdManager.Instance.Ads.Count)
        {
            currentAdIndex = 0;
        }
        
        var ad = AdManager.Instance.Ads[currentAdIndex];
        
        adTitle.DOFade(0, 0.2f);
        adContent.DOFade(0, 0.2f);
        yield return new WaitForSeconds(0.2f);
        
        adTitle.text = ad.title;
        adContent.text = ad.content;
        
        adTitle.DOFade(1, 0.2f); 
        adContent.DOFade(1, 0.2f);
        yield return new WaitForSeconds(0.2f);
        
        currentAdIndex++;
    }
}
