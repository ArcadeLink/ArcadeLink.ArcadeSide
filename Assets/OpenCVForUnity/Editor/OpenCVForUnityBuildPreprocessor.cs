using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace OpenCVForUnity.Editor
{

    public class OpenCVForUnityBuildPreprocessor : IPreprocessBuildWithReport
    {

        public void OnPreprocessBuild(BuildReport report)
        {
            string[] guids = UnityEditor.AssetDatabase.FindAssets("OpenCVForUnityBuildPreprocessor");
            if (guids.Length == 0)
            {
                Debug.LogWarning("SetPluginImportSettings Faild : OpenCVForUnityBuildPreprocessor.cs is missing.");
                return;
            }
            string opencvForUnityFolderPath = AssetDatabase.GUIDToAssetPath(guids[0]).Substring(0, AssetDatabase.GUIDToAssetPath(guids[0]).LastIndexOf("/Editor/OpenCVForUnityBuildPreprocessor.cs"));

            string pluginsFolderPath = opencvForUnityFolderPath + "/Plugins";
            //Debug.Log("pluginsFolderPath " + pluginsFolderPath);

            string extraFolderPath = opencvForUnityFolderPath + "/Extra";
            //Debug.Log("extraFolderPath " + extraFolderPath);

            Debug.Log("OpenCVForUnityBuildPreprocessor " + report.summary.platform);

            switch (report.summary.platform)
            {
#if UNITY_2017_3_OR_NEWER
                case BuildTarget.StandaloneOSX:
#else
                case BuildTarget.StandaloneOSXUniversal:
                case BuildTarget.StandaloneOSXIntel:
                case BuildTarget.StandaloneOSXIntel64:
#endif
                    OpenCVForUnityMenuItem.SetOSXPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.StandaloneWindows:
                case BuildTarget.StandaloneWindows64:

                    OpenCVForUnityMenuItem.SetWindowsPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.iOS:

                    OpenCVForUnityMenuItem.SetIOSPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.Android:

                    OpenCVForUnityMenuItem.SetAndroidPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
#if UNITY_2019_2_OR_NEWER
                case BuildTarget.StandaloneLinux64:
#else
                case BuildTarget.StandaloneLinux:    
                case BuildTarget.StandaloneLinux64:
                case BuildTarget.StandaloneLinuxUniversal:
#endif

                    OpenCVForUnityMenuItem.SetLinuxPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.WebGL:

                    OpenCVForUnityMenuItem.SetWebGLPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.WSAPlayer:

                    OpenCVForUnityMenuItem.SetUWPPluginImportSettings(pluginsFolderPath, extraFolderPath);
                    break;
                case BuildTarget.NoTarget:

                    break;
                default:

                    break;
            }

        }

        public int callbackOrder { get { return 0; } }
    }
}

