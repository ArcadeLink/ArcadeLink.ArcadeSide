using System;
using UnityEngine;

namespace Managers
{
    public class StateManager : MonoBehaviour
    {
        public States CurrentState { get; private set; } = States.Empty;
        
        public static StateManager Instance { get; private set; }
        
        private bool maintenceMode => SettingsManager.Instance.Settings.MaintainceMode;

        private void Awake()
        {
            Instance = this;
        }

        public void SetState(States state)
        {
            Debug.Log("Setting state to: " + state.ToString().Replace("_", " "));

            if (maintenceMode && (state != States.Maintence | state != States.Setting_Window))
            {
                return;
            }
            
            switch (CurrentState)
            {
                case States.Maintence:
                    if (state == States.Setting_Window | state == States.Empty)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }

                    break; 
                case States.Main_Window:
                    if (
                        state == States.Scan_Window | 
                        state == States.Setting_Window)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }
                    break;
                case States.Scan_Window:
                    if (
                        state == States.Main_Window | 
                        state == States.Join_Window |
                        state == States.Record_Window |
                        state == States.Static_Window)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }
                    break;
                case States.Join_Window:
                    if (state == States.Main_Window)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }
                    break;
                case States.Empty:
                    CurrentState = state;
                    SceneManager.Instance.SetActiveScene(state.ToString());
                    break;
                case States.Setting_Window:
                    if (state == States.Main_Window)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }
                    break;
                case States.Record_Window:
                    if (state == States.Scan_Window |
                        state == States.Main_Window)
                    {
                        CurrentState = state;
                        SceneManager.Instance.SetActiveScene(state.ToString());
                    }
                    break;
                case States.Static_Window:
                    CurrentState = state;
                    SceneManager.Instance.SetActiveScene(state.ToString());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void Start()
        {
            if (SettingsManager.Instance.Settings.MaintainceMode)
            {
                SetState(States.Maintence);
            }
            else
            {
                SetState(States.Main_Window);
            }
            
        }

        private void Update()
        {
            if (Input.GetButtonDown("Scan"))
            {
                SetState(States.Scan_Window);
            }
        }
    }

    public enum States
    {
        Main_Window,
        Scan_Window,
        Join_Window,
        Setting_Window,
        Record_Window,
        Static_Window,
        Maintence,
        Empty,
    }
}