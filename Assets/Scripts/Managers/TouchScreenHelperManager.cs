using Managers;
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class TouchScreenHelperManager : MonoBehaviour
{
    public static TouchScreenHelperManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public bool IsTouchScreen()
    {
        return Input.touchSupported;
    }
    
    public void ResetScene()
    {
        SceneManager.LoadScene("Scaffold Scene");
    }

    private int _clickCount = 0;
    public void TriggerClick()
    {
        // 点击10次触发设置模式
        if (_clickCount != 10)
        {
            _clickCount++;
            return;
        }
        
        // 重置点击次数
        _clickCount = 0;
        
        // 触发设置模式
        StateManager.Instance.SetState(StateManager.Instance.CurrentState == States.Setting_Window
            ? States.Main_Window
            : States.Setting_Window);
    }
}
