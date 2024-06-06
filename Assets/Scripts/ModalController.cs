using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModalController : MonoBehaviour
{
    public static ModalController Instance { get; private set; }
    
    [SerializeField]
    private TMP_Text ModalTitle, ModalContent;
    [SerializeField]
    private Image ProgressBar;
    [SerializeField]
    private AudioSource audioSource;
    
    private bool isShowing;
    private void Awake()
    {
        Instance = this;
    }
    
    public async UniTask ShowModal(string title, string content, float time = 5f)
    {
        if (isShowing)
        {
            return;
        }
        
        isShowing = true;
        
        ModalTitle.text = title;
        ModalContent.text = content;
        ProgressBar.fillAmount = 1;

        audioSource.Play();
        GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        await UniTask.Delay(1000);

        ProgressBar.DOFillAmount(0, time).onComplete += () =>
        {
            GetComponent<CanvasGroup>().DOFade(0, 0.5f);
            isShowing = false;
        };
    }
}