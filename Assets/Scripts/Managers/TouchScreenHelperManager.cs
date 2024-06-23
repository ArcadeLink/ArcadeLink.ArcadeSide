using ANU.IngameDebug.Console;
using UnityEngine;

namespace Managers
{
    public class TouchScreenHelperManager : MonoBehaviour
    {
        public static TouchScreenHelperManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            
            DontDestroyOnLoad(gameObject);
        }

        private int _clickCount;
        public void TriggerClick()
        {
            _clickCount++;
            
            if (StateManager.Instance.CurrentState == States.Main_Window && _clickCount >= 8)
            {
                // 触发设置模式
                DebugConsole.Open();
                _clickCount = 0;
            }
            else if (StateManager.Instance.CurrentState != States.Main_Window && _clickCount >= 4)
            {
                Destroy(GameObject.Find("DebugConsole"));
                Destroy(GameObject.Find("Main Camera"));
                UnityEngine.SceneManagement.SceneManager.LoadScene("Setup Scene");
                _clickCount = 0;
            }
        }
    }
}
