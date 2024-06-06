using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Models;
using ModularMotion;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;

namespace Setup
{
    public class SetupSceneController : MonoBehaviour
    {
        public static SetupSceneController Instance { get; private set; }
        
        [SerializeField] private TMP_Text configTestText;
        [SerializeField] private CanvasGroup transitionCanvasGroup;
    
        [SerializeField] private CanvasGroup setupCanvasGroup, setupCompleteCanvasGroup;
        [SerializeField] private List<SetupControllerBase> setupControllers;
        
        [SerializeField] private UIMotion setupCompleteTextMotion;
        
        public SettingsModel Settings { get; } = new();
    
        private bool IsConfigSetup { get; set; }
        private bool IsSettingUp { get; set; }
        private bool IsSetupComplete { get; set; }

        private void Awake()
        {
            setupControllers = FindObjectsOfType<SetupControllerBase>().ToList();
            Instance = this;
        }

        private async void Start()
        {
            TestConfig();
        
            await UniTask.WaitForSeconds(1);

            if (IsConfigSetup)
            {
                configTestText.text = "启动中...";
                transitionCanvasGroup.DOFade(1, 0.5f).onComplete += () =>
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Scaffold Scene");
                };
                return;
            }

            configTestText.text = "按任意键开始设置";
        }

        private void Update()
        {
            if (Input.anyKeyDown)
            {
                if (!IsSettingUp  && !IsConfigSetup)
                {
                    StartSetup();
                }

                if (IsSetupComplete)
                {
                    OnCompleteButtonClicked();
                }
                
            }
        }

        private void StartSetup()
        {
            IsSettingUp = true;
            setupCanvasGroup.DOFade(1, 1f).onComplete += StartSetupSteps;
        }

        private void OnCompleteButtonClicked()
        {
            if (Settings == null)
            {
                return;
            }
            
            SaveSettings();
            
            configTestText.text = "启动中...";
            transitionCanvasGroup.DOFade(1, 1f).onComplete += () =>
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Scaffold Scene");
            };
            return;
        }

        private void SaveSettings()
        {
            var configPath = $"{Application.persistentDataPath}/settings.json";
            var settingsJson = JsonConvert.SerializeObject(Settings);
            Debug.Log($"Saving {settingsJson} to {configPath}");
            File.WriteAllText(configPath, settingsJson);
        }

        private async void StartSetupSteps()
        {
            setupCanvasGroup.interactable = true;
            setupCanvasGroup.blocksRaycasts = true;

            setupControllers.Sort((a, b) => a.SetupStep.CompareTo(b.SetupStep));
            
            foreach (var setupController in setupControllers)
            {
                setupController.StartSetup();
                await UniTask.WaitUntil(() => setupController.IsSetupComplete);
                setupController.EndStep();
            }
            
            setupCompleteCanvasGroup.DOFade(1, 1f).onComplete += () =>
            {
                setupCompleteCanvasGroup.interactable = true;
                setupCompleteCanvasGroup.blocksRaycasts = true;
                setupCanvasGroup.DOFade(0, 1f).onComplete += () =>
                {
                    setupCanvasGroup.interactable = false;
                    setupCanvasGroup.blocksRaycasts = false;
                    
                    setupCompleteTextMotion.Play();
                };
            };
            
            IsSetupComplete = true;
        }

        private void TestConfig()
        {
            configTestText.text = "正在测试配置文件...";

            var configPath = $"{Application.persistentDataPath}/settings.json";
            if (!File.Exists(configPath))
            {
                IsConfigSetup = false;
                return;
            }
        
            var configText = File.ReadAllText(configPath);
            try
            {
                var settings = JsonConvert.DeserializeObject<SettingsModel>(configText);
                if (settings == null)
                {
                    IsConfigSetup = false;
                    return;
                }
            }
            catch (Exception e)
            {
                IsConfigSetup = false;
                Debug.LogError(e);
            }
        
            IsConfigSetup = true;
        }
    }
}
