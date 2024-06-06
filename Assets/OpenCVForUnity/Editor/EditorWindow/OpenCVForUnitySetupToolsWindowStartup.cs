using UnityEditor;
using UnityEngine;

namespace OpenCVForUnity.Editor
{

    [InitializeOnLoad]
    public class OpenCVForUnitySetupToolsWindowStartup
    {

        static OpenCVForUnitySetupToolsWindowStartup()
        {

            EditorApplication.update -= ShowSetupToolsWindow;
            EditorApplication.update += ShowSetupToolsWindow;

            EditorApplication.playModeStateChanged -= PlayModeChanged;
            EditorApplication.playModeStateChanged += PlayModeChanged;

        }

        private static void ShowSetupToolsWindow()
        {

            //Debug.Log("OpenCVForUnityProjectSettings.Instance.showSetupToolsWindowFlag: " + OpenCVForUnityProjectSettings.Instance.showSetupToolsWindowFlag);

            var showAtStartup = OpenCVForUnityProjectSettings.Instance.showSetupToolsWindowFlag;

            if (showAtStartup)
            {
                OpenCVForUnitySetupToolsWindow.OpenSetupToolsWindow();

                OpenCVForUnityProjectSettings.Instance.showSetupToolsWindowFlag = false;
                EditorUtility.SetDirty(OpenCVForUnityProjectSettings.Instance);
            }

            EditorApplication.update -= ShowSetupToolsWindow;
        }

        private static void PlayModeChanged(PlayModeStateChange playMode)
        {
            EditorApplication.update -= ShowSetupToolsWindow;
        }
    }
}
