using Cysharp.Threading.Tasks;
using Interfaces;
using ModularMotion;
using RestEase;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class SceneManager : MonoBehaviour
    {
        [SerializeField]
        private UIMotion TransitionMotion;
        [SerializeField]
        private TMP_Text TransitionText;
        
        [SerializeField]
        private AudioSource TransitionAudio;
        
        public static SceneManager Instance { get; private set; }

        private string CurrentScene { get; set; }

        private void Awake()
        {
            Instance = this;
        }
    
        public async void SetActiveScene(string sceneName)
        {
            sceneName = sceneName.Replace("_", " ");
            
            TransitionMotion.ResetMotion();
            
            TransitionAudio.Play();
            
            TransitionMotion.PlayNext();

            if (CurrentScene != null)
            {
                Debug.Log("Unloading scene: " + CurrentScene);
                await UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(CurrentScene);
            }
            CurrentScene = sceneName;
            Debug.Log("Loading scene: " + sceneName);

            await UniTask.Delay(200);
            await UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            await UniTask.Delay(800);

            TransitionAudio.Play();
            TransitionMotion.PlayNext();
            
            await UniTask.Delay(200);
            
            UpdateText();
        }
        
        private async void UpdateText()
        {
            // Use GetRandomSayings Api to get the text
            var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
            var docs = await api.GetRandomSayings();
            var doc = docs.data.ToString();

            TransitionText.text = doc;
        }
    }
}
