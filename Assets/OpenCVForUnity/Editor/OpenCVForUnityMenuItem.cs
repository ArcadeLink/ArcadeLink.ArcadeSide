#if UNITY_5 || UNITY_5_3_OR_NEWER
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
#if UNITY_2021_2_OR_NEWER
using UnityEditor.Build;
#endif

namespace OpenCVForUnity.Editor
{
    public class OpenCVForUnityMenuItem : MonoBehaviour
    {

        static int pluginFileIndex = 0;
        static int pluginFileCount = 0;

        static int GetPluginFileCount(string folderPath)
        {

            int pluginFileCount = 0;

            Regex reg = new Regex(".meta$|.DS_Store$|.zip$|.bundle|.framework");
            try
            {
                pluginFileCount += Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).Where(f => !reg.IsMatch(f)).Count();
            }
            catch (Exception)
            {
                //Debug.LogWarning("SetPluginImportSettings Faild :" + ex);
                return 0;
            }

            pluginFileCount += Directory.GetDirectories(folderPath, "*.bundle", SearchOption.AllDirectories).Count();
            pluginFileCount += Directory.GetDirectories(folderPath, "*.framework", SearchOption.AllDirectories).Count();

            return pluginFileCount;
        }

        static string[] GetPluginFilePaths(string folderPath)
        {
            Regex reg = new Regex(".meta$|.DS_Store$|.zip");
            try
            {

                return Directory.GetFiles(folderPath).Where(f => !reg.IsMatch(f)).Select(n => n.Replace("\\", "/")).ToArray();

            }
            catch (Exception)
            {
                //Debug.LogWarning("SetPluginImportSettings Faild :" + ex);
                return null;
            }
        }

        public static void SetPluginImportSettings()
        {
            try
            {

                string[] guids = UnityEditor.AssetDatabase.FindAssets("OpenCVForUnityMenuItem");
                if (guids.Length == 0)
                {
                    Debug.LogWarning("SetPluginImportSettings Faild : OpenCVForUnityMenuItem.cs is missing.");
                    return;
                }
                string opencvForUnityFolderPath = AssetDatabase.GUIDToAssetPath(guids[0]).Substring(0, AssetDatabase.GUIDToAssetPath(guids[0]).LastIndexOf("/Editor/OpenCVForUnityMenuItem.cs"));

                string pluginsFolderPath = opencvForUnityFolderPath + "/Plugins";
                //Debug.Log("pluginsFolderPath " + pluginsFolderPath);

                string extraFolderPath = opencvForUnityFolderPath + "/Extra";
                //Debug.Log("extraFolderPath " + extraFolderPath);

                pluginFileIndex = 0;
                pluginFileCount = GetPluginFileCount(pluginsFolderPath) + GetPluginFileCount(extraFolderPath);


                //Android
                SetAndroidPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //iOS
                SetIOSPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //OSX
                SetOSXPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //Windows
                SetWindowsPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //Linux
                SetLinuxPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //UWP
                SetUWPPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

                //WebGL
                SetWebGLPluginImportSettings(pluginsFolderPath, extraFolderPath, true);

            }
            catch (Exception e)
            {

                Debug.Log("SetPluginImportSettings() " + e);
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }

            //Debug.Log("pluginFilesIndex " + pluginFileIndex);
            //Debug.Log("pluginFilesCount " + pluginFileCount);
        }

        public static void SetAndroidPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/exclude_contrib/Android/libs/armeabi-v7a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/exclude_contrib/Android/libs/arm64-v8a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/exclude_contrib/Android/libs/x86"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/exclude_contrib/Android/libs/x86_64"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/armeabi-v7a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/arm64-v8a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/x86"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/x86_64"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/exclude_contrib/libs/armeabi-v7a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/exclude_contrib/libs/arm64-v8a"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/exclude_contrib/libs/x86"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/exclude_contrib/libs/x86_64"), null, null, displayProgressBar);

            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/armeabi-v7a"), null,
    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.Android,new Dictionary<string, string> () { {
                                            "CPU",
                                            "ARMv7"
                                        }
                                    }
                                }
    }, displayProgressBar);
#if UNITY_2018_1_OR_NEWER
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/arm64-v8a"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.Android,new Dictionary<string, string> () { {
                                            "CPU",
                                            "ARM64"
                                        }
                                    }
                                }
                }, displayProgressBar);
#else
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/arm64-v8a"), null, null, displayProgressBar);
#endif
#if UNITY_2021_2_OR_NEWER
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/x86"), null,
                    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.Android,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86"
                                        }
                                    }
                                }
                    }, displayProgressBar);
#else
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/x86"), null, null, displayProgressBar);
#endif
#if UNITY_2021_2_OR_NEWER
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/x86_64"), null,
                    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.Android,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86_64"
                                        }
                                    }
                                }
                    }, displayProgressBar);
#else
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Android/libs/x86_64"), null, null, displayProgressBar);
#endif
        }

        public static void SetIOSPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
            SetPlugins(new string[] { extraFolderPath + "/exclude_contrib/iOS/opencv2.framework" }, null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/exclude_contrib/iOS"), null, null, displayProgressBar);

            SetPlugins(new string[] { pluginsFolderPath + "/iOS/opencv2.framework" }, null,
    new Dictionary<BuildTarget, Dictionary<string, string>>() { {
                                    BuildTarget.iOS,
                                    new Dictionary<string, string> () { {
                                            "AddToEmbeddedBinaries",
                                            "true"
                                        }
                                    }
                                }
    }, displayProgressBar);
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/iOS"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {
                                    BuildTarget.iOS,
                                    null
                                }
                }, displayProgressBar);
        }

        public static void SetOSXPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
            SetPlugins(new string[] { pluginsFolderPath + "/macOS/opencvforunity.bundle" }, new Dictionary<string, string>() { {
                                "CPU",
                                "AnyCPU"
                            }, {
                                "OS",
                                "OSX"
                            }
                        },
    new Dictionary<BuildTarget, Dictionary<string, string>>() {
#if UNITY_2017_3_OR_NEWER
                                {
                                    BuildTarget.StandaloneOSX,new Dictionary<string, string> () { {
                                            "CPU",
                                            "AnyCPU"
                                        }
                                    }
                                }
#else
                                {
                                    BuildTarget.StandaloneOSXIntel,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86"
                                        }
                                    }
                                }, {
                                    BuildTarget.StandaloneOSXIntel64,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86_64"
                                        }
                                    }
                                }, {
                                    BuildTarget.StandaloneOSXUniversal,new Dictionary<string, string> () { {
                                            "CPU",
                                            "AnyCPU"
                                        }
                                    }
                                }
#endif
    }, displayProgressBar);
        }


        public static void SetWindowsPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
            SetPlugins(new string[] { extraFolderPath + "/dll_version/Windows/x86/opencvforunity.dll" }, null, null, displayProgressBar);
            SetPlugins(new string[] { extraFolderPath + "/dll_version/Windows/x86_64/opencvforunity.dll" }, null, null, displayProgressBar);
            SetPlugins(new string[] { extraFolderPath + "/dll_version/Windows/ARM64/opencvforunity.dll" }, null, null, displayProgressBar);

            SetPlugins(new string[] { pluginsFolderPath + "/Windows/x86/opencvforunity.dll" }, new Dictionary<string, string>() { {
                                "CPU",
                                "x86"
                            }, {
                                "OS",
                                "Windows"
                            }
                        },
    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.StandaloneWindows,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86"
                                        }
                                    }
                                }
    }, displayProgressBar);
            SetPlugins(new string[] { pluginsFolderPath + "/Windows/x86_64/opencvforunity.dll" }, new Dictionary<string, string>() { {
                                "CPU",
                                "x86_64"
                            }, {
                                "OS",
                                "Windows"
                            }
                        },
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.StandaloneWindows64,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86_64"
                                        }
                                    }
                                }
                }, displayProgressBar);
#if UNITY_2023_1_OR_NEWER
            SetPlugins(new string[] { pluginsFolderPath + "/Windows/ARM64/opencvforunity.dll" }, new Dictionary<string, string>() { {
                                "CPU",
                                "ARM64"
                            }, {
                                "OS",
                                "Windows"
                            }
                        },
    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.StandaloneWindows64,new Dictionary<string, string> () { {
                                            "CPU",
                                            "ARM64"
                                        }
                                    }
                                }
    }, displayProgressBar);
#endif
        }

        public static void SetLinuxPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Linux/x86_64"), new Dictionary<string, string>() { {
                                "CPU",
                                "x86_64"
                            }, {
                                "OS",
                                "Linux"
                            }
                        },
    new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.StandaloneLinux64,new Dictionary<string, string> () { {
                                            "CPU",
                                            "x86_64"
                                        }
                                    }
                                },
    }, displayProgressBar);
        }

            public static void SetUWPPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {
#if UNITY_5_0 || UNITY_5_1
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/ARM"), null, null, displayProgressBar);
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/ARM64"), null, null, displayProgressBar);
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/x64"), null, null, displayProgressBar);
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/x86"), null, null, displayProgressBar);
#else
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/ARM"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                            "SDK",
                                            "UWP"
                                        }, {
                                            "CPU",
                                            "ARM"
                                        }
                                    }
                                }
                }, displayProgressBar);
#if UNITY_2019_1_OR_NEWER
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/ARM64"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                            "SDK",
                                            "UWP"
                                        }, {
                                            "CPU",
                                            "ARM64"
                                        }
                                    }
                                }
                }, displayProgressBar);
#else
                SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/ARM64"), null, null, displayProgressBar);
#endif
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/x64"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                            "SDK",
                                            "UWP"
                                        }, {
                                            "CPU",
                                            "x64"
                                        }
                                    }
                                }
                }, displayProgressBar);
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WSA/UWP/x86"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>>() { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                            "SDK",
                                            "UWP"
                                        }, {
                                            "CPU",
                                            "x86"
                                        }
                                    }
                                }
                }, displayProgressBar);
#endif
        }

        public static void SetWebGLPluginImportSettings(string pluginsFolderPath, string extraFolderPath, bool displayProgressBar = false)
        {

            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WebGL/2021.2"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WebGL/2022.2"), null, null, displayProgressBar);
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/WebGL/2023.2"), null, null, displayProgressBar);

            string version = "2021.2";
#if UNITY_2023_2_OR_NEWER
            version = "2023.2"; 
#elif UNITY_2022_2_OR_NEWER
            version = "2022.2";
#elif UNITY_2021_2_OR_NEWER
            version = "2021.2";
#endif

#if UNITY_2021_2_OR_NEWER
            bool threads = ValidateUseWebGLThreadsSupport();
            bool simd = ValidateUseWebGLSIMDSupport();

            if(threads && simd)
            {
                SetPlugins(new string[] { pluginsFolderPath + "/WebGL/" + version + "/opencvforunity_threads_simd.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>>() { {
                                            BuildTarget.WebGL,
                                            null
                                        }
                                    }, displayProgressBar);
            }else if (threads)
            {
                SetPlugins(new string[] { pluginsFolderPath + "/WebGL/" + version + "/opencvforunity_threads.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>>() { {
                                            BuildTarget.WebGL,
                                            null
                                        }
                                    }, displayProgressBar);
            }
            else
            {
                SetPlugins(new string[] { pluginsFolderPath + "/WebGL/" + version + "/opencvforunity.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>>() { {
                                            BuildTarget.WebGL,
                                            null
                                        }
                                    }, displayProgressBar);
            }
#else
            Debug.LogError("The WebGL platform build of OpenCVForUnity is not supported in versions of Unity under " + version + ".");
#endif

            if (PlayerSettings.WebGL.exceptionSupport == WebGLExceptionSupport.None)
                PlayerSettings.WebGL.exceptionSupport = WebGLExceptionSupport.ExplicitlyThrownExceptionsOnly;
        }

        private static void SetPlugins(string[] files, Dictionary<string, string> editorSettings, Dictionary<BuildTarget, Dictionary<string, string>> settings, bool displayProgressBar)
        {
            if (files == null)
                return;

            foreach (string item in files)
            {

                PluginImporter pluginImporter = PluginImporter.GetAtPath(item) as PluginImporter;

                if (pluginImporter != null)
                {
                    //if(displayProgressBar) EditorUtility.DisplayProgressBar("Set Plugin Import Settings", item, 1);
                    if (displayProgressBar)
                    {
                        EditorUtility.DisplayProgressBar("Set Plugin Import Settings", string.Format("{0} / {1} " + item, pluginFileIndex + 1, pluginFileCount), (float)pluginFileIndex / pluginFileCount);
                        pluginFileIndex++;
                    }

                    pluginImporter.SetCompatibleWithAnyPlatform(false);
                    pluginImporter.SetCompatibleWithEditor(false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.Android, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.iOS, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneWindows, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneWindows64, false);
#if UNITY_2017_3_OR_NEWER
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSX, false);
#else
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXIntel, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXIntel64, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXUniversal, false);
#endif
#if UNITY_2019_2_OR_NEWER
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux64, false);
#else
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux64, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinuxUniversal, false);
#endif
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.WSAPlayer, false);
                    pluginImporter.SetCompatibleWithPlatform(BuildTarget.WebGL, false);

                    if (editorSettings != null)
                    {
                        pluginImporter.SetCompatibleWithEditor(true);


                        foreach (KeyValuePair<string, string> pair in editorSettings)
                        {
                            if (pluginImporter.GetEditorData(pair.Key) != pair.Value)
                            {
                                pluginImporter.SetEditorData(pair.Key, pair.Value);
                            }
                        }
                    }

                    if (settings != null)
                    {
                        foreach (KeyValuePair<BuildTarget, Dictionary<string, string>> settingPair in settings)
                        {

                            pluginImporter.SetCompatibleWithPlatform(settingPair.Key, true);
                            if (settingPair.Value != null)
                            {
                                foreach (KeyValuePair<string, string> pair in settingPair.Value)
                                {
                                    if (pluginImporter.GetPlatformData(settingPair.Key, pair.Key) != pair.Value)
                                    {
                                        pluginImporter.SetPlatformData(settingPair.Key, pair.Key, pair.Value);
                                    }
                                }
                            }

                        }

#if UNITY_2019_1_OR_NEWER
                        pluginImporter.isPreloaded = true;
#endif
                    }
                    else
                    {
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.Android, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.iOS, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneWindows, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneWindows64, false);
#if UNITY_2017_3_OR_NEWER
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSX, false);
#else
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXIntel, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXIntel64, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneOSXUniversal, false);
#endif
#if UNITY_2019_2_OR_NEWER
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux64, false);
#else
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinux64, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.StandaloneLinuxUniversal, false);
#endif
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.WSAPlayer, false);
                        pluginImporter.SetCompatibleWithPlatform(BuildTarget.WebGL, false);

#if UNITY_2019_1_OR_NEWER
                        pluginImporter.isPreloaded = false;
#endif
                    }

                    pluginImporter.SaveAndReimport();

                    if (displayProgressBar) Debug.Log("SetPluginImportSettings Success :" + item);

                }
                else
                {
                    //Debug.LogWarning("SetPluginImportSettings Faild :" + item);
                }
            }
        }

#if UNITY_2018_1_OR_NEWER

        static readonly string SYMBOL_OPENCV_USE_UNSAFE_CODE = "OPENCV_USE_UNSAFE_CODE";

        //[MenuItem("Tools/OpenCV for Unity/Use Unsafe Code", validate = true, priority = 12)]
        public static bool ValidateUseUnsafeCode()
        {
            //Menu.SetChecked("Tools/OpenCV for Unity/Use Unsafe Code", EditorUserBuildSettings.activeScriptCompilationDefines.Contains(SYMBOL_OPENCV_USE_UNSAFE_CODE));
            //return true;
            return EditorUserBuildSettings.activeScriptCompilationDefines.Contains(SYMBOL_OPENCV_USE_UNSAFE_CODE);
        }

        //[MenuItem("Tools/OpenCV for Unity/Use Unsafe Code", validate = false, priority = 12)]
        public static void UseUnsafeCode(bool enable)
        {
            //if (Menu.GetChecked("Tools/OpenCV for Unity/Use Unsafe Code"))
            //{
            if (!enable) {
                if (EditorUtility.DisplayDialog("Disable Unsafe Code",
                "Do you want to disable Unsafe Code in OpenCV for Unity?", "Yes", "Cancel"))
                {
#if UNITY_2021_2_OR_NEWER
                    Symbol.Remove(NamedBuildTarget.Standalone, Symbol.GetCurrentSymbols(NamedBuildTarget.Standalone), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(NamedBuildTarget.Android, Symbol.GetCurrentSymbols(NamedBuildTarget.Android), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(NamedBuildTarget.iOS, Symbol.GetCurrentSymbols(NamedBuildTarget.iOS), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(NamedBuildTarget.WebGL, Symbol.GetCurrentSymbols(NamedBuildTarget.WebGL), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(NamedBuildTarget.WindowsStoreApps, Symbol.GetCurrentSymbols(NamedBuildTarget.WindowsStoreApps ), SYMBOL_OPENCV_USE_UNSAFE_CODE);
#else
                    Symbol.Remove(BuildTargetGroup.Standalone, Symbol.GetCurrentSymbols(BuildTargetGroup.Standalone), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(BuildTargetGroup.Android, Symbol.GetCurrentSymbols(BuildTargetGroup.Android), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(BuildTargetGroup.iOS, Symbol.GetCurrentSymbols(BuildTargetGroup.iOS), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(BuildTargetGroup.WebGL, Symbol.GetCurrentSymbols(BuildTargetGroup.WebGL), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Remove(BuildTargetGroup.WSA, Symbol.GetCurrentSymbols(BuildTargetGroup.WSA), SYMBOL_OPENCV_USE_UNSAFE_CODE);
#endif
                    Debug.Log("\"" + SYMBOL_OPENCV_USE_UNSAFE_CODE + "\" has been removed from Scripting Define Symbols.");
                    EditorUtility.DisplayDialog("success!!",
                "\"" + SYMBOL_OPENCV_USE_UNSAFE_CODE + "\" has been removed from Scripting Define Symbols.", "OK");
                }
            }
            else
            {
                if (EditorUtility.DisplayDialog("Enable Unsafe Code",
                "Do you want to enable Unsafe Code in OpenCV for Unity?", "Yes", "Cancel"))
                {
#if UNITY_2021_2_OR_NEWER
                    Symbol.Add(NamedBuildTarget.Standalone, Symbol.GetCurrentSymbols(NamedBuildTarget.Standalone), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(NamedBuildTarget.Android, Symbol.GetCurrentSymbols(NamedBuildTarget.Android), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(NamedBuildTarget.iOS, Symbol.GetCurrentSymbols(NamedBuildTarget.iOS), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(NamedBuildTarget.WebGL, Symbol.GetCurrentSymbols(NamedBuildTarget.WebGL), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(NamedBuildTarget.WindowsStoreApps, Symbol.GetCurrentSymbols(NamedBuildTarget.WindowsStoreApps), SYMBOL_OPENCV_USE_UNSAFE_CODE);
#else
                    Symbol.Add(BuildTargetGroup.Standalone, Symbol.GetCurrentSymbols(BuildTargetGroup.Standalone), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(BuildTargetGroup.Android, Symbol.GetCurrentSymbols(BuildTargetGroup.Android), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(BuildTargetGroup.iOS, Symbol.GetCurrentSymbols(BuildTargetGroup.iOS), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(BuildTargetGroup.WebGL, Symbol.GetCurrentSymbols(BuildTargetGroup.WebGL), SYMBOL_OPENCV_USE_UNSAFE_CODE);
                    Symbol.Add(BuildTargetGroup.WSA, Symbol.GetCurrentSymbols(BuildTargetGroup.WSA), SYMBOL_OPENCV_USE_UNSAFE_CODE);
#endif

                    Debug.Log("\"" + SYMBOL_OPENCV_USE_UNSAFE_CODE + "\" has been added to Scripting Define Symbols.");
                    EditorUtility.DisplayDialog("success!!",
                        "\"" + SYMBOL_OPENCV_USE_UNSAFE_CODE + "\" has been added to Scripting Define Symbols.", "OK");
                }
            }
        }

        static class Symbol
        {
#if UNITY_2021_2_OR_NEWER
            public static IEnumerable<string> GetCurrentSymbols(NamedBuildTarget nameBuildTarget)
            {
                return PlayerSettings.GetScriptingDefineSymbols(nameBuildTarget).Split(';');
            }

            private static void SaveSymbol(NamedBuildTarget nameBuildTarget, IEnumerable<string> currentSymbols)
            {

                var symbols = String.Join(";", currentSymbols.ToArray());

                PlayerSettings.SetScriptingDefineSymbols(nameBuildTarget, symbols);

            }

            public static void Add(NamedBuildTarget nameBuildTarget, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                currentSymbols = currentSymbols.Except(symbols);
                currentSymbols = currentSymbols.Concat(symbols).Distinct();
                SaveSymbol(nameBuildTarget, currentSymbols);
            }

            public static void Remove(NamedBuildTarget nameBuildTarget, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                currentSymbols = currentSymbols.Except(symbols);
                SaveSymbol(nameBuildTarget, currentSymbols);
            }

            public static void Set(NamedBuildTarget nameBuildTarget, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                SaveSymbol(nameBuildTarget, symbols);
            }
#else
            public static IEnumerable<string> GetCurrentSymbols(BuildTargetGroup buildTargetGroup)
            {
                return PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup).Split(';');
            }

            private static void SaveSymbol(BuildTargetGroup buildTargetGroup, IEnumerable<string> currentSymbols)
            {

                var symbols = String.Join(";", currentSymbols.ToArray());

                PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, symbols);

            }

            public static void Add(BuildTargetGroup buildTargetGroup, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                currentSymbols = currentSymbols.Except(symbols);
                currentSymbols = currentSymbols.Concat(symbols).Distinct();
                SaveSymbol(buildTargetGroup, currentSymbols);
            }

            public static void Remove(BuildTargetGroup buildTargetGroup, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                currentSymbols = currentSymbols.Except(symbols);
                SaveSymbol(buildTargetGroup, currentSymbols);
            }

            public static void Set(BuildTargetGroup buildTargetGroup, IEnumerable<string> currentSymbols, params string[] symbols)
            {
                SaveSymbol(buildTargetGroup, symbols);
            }
#endif
        }
#endif

        public static bool ValidateUseWebGLThreadsSupport()
        {
            return PlayerSettings.WebGL.threadsSupport;
        }

        public static void UseWebGLThreadsSupport(bool enable)
        {
            PlayerSettings.WebGL.threadsSupport = enable;
        }

        public static bool ValidateUseWebGLSIMDSupport()
        {
            return PlayerSettings.WebGL.emscriptenArgs.Contains("-msimd128");
        }

        public static void UseWebGLSIMDSupport(bool enable)
        {
            if (enable)
            {
                PlayerSettings.WebGL.emscriptenArgs += "-msimd128";
            }
            else
            {
                PlayerSettings.WebGL.emscriptenArgs = PlayerSettings.WebGL.emscriptenArgs.Replace("-msimd128","");
            }
        }

        //[MenuItem("Tools/OpenCV for Unity/Import Extra Package", false, 24)]
        public static void ImportExtraPackage()
        {
            AssetDatabase.ImportPackage("Assets/OpenCVForUnity/Extra.unitypackage", true);
        }

        [MenuItem("Tools/OpenCV for Unity/Open OpenCV for Unity API Reference", false, 35)]
        public static void OpenOpenCVForUnityAPIReference()
        {
            Application.OpenURL("http://enoxsoftware.github.io/OpenCVForUnity/3.0.0/doc/html/index.html");
        }

        [MenuItem("Tools/OpenCV for Unity/Open OpenCV C++ API Reference", false, 36)]
        public static void OpenOpenCVAPIReference()
        {
            Application.OpenURL("http://docs.opencv.org/4.8.0/index.html");
        }
    }
}
#endif