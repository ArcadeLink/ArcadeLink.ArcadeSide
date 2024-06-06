using System;
using DG.Tweening;
using Managers;
using UnityEngine;
using UnityEngine.UI;

public class TimeoutProgressBar : MonoBehaviour
{
    [SerializeField]
    private float Timeout = 20f;
    [SerializeField]
    private Image ProgressBar;
    [SerializeField]
    private States TimeoutFallbackState = States.Main_Window;

    private void Start()
    {
        ProgressBar.fillAmount = 1f;
        timer = Timeout;
    }

    private float timer;
    private bool isPaused;
    private void Update()
    {
        if (isPaused) return;
        
        if (timer <= 0)
        {
            StateManager.Instance.SetState(TimeoutFallbackState);
            return;
        }

        timer -= Time.deltaTime;
        ProgressBar.fillAmount = timer / Timeout;
    }
    
    public void ResetTimer()
    {
        timer = Timeout;
    }
    
    public void PauseTimer()
    {
        isPaused = true;
    }
    
    public void ResumeTimer()
    {
        isPaused = false;
    }
}