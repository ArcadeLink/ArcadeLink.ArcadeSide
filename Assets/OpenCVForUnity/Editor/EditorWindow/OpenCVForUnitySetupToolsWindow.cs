using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections.Generic;

namespace OpenCVForUnity.Editor
{

    public class OpenCVForUnitySetupToolsWindow : EditorWindow
    {

        private Vector2 _scrollPosition = Vector2.zero;


        [MenuItem("Tools/OpenCV for Unity/Open Setup Tools", false, 1)]
        public static void OpenSetupToolsWindow()
        {

            OpenCVForUnitySetupToolsWindow m_Window = GetWindow<OpenCVForUnitySetupToolsWindow>(true,"OpenCV for Unity | Setup Tools");
            m_Window.minSize = new Vector2(320, 780);
            //m_Window.maxSize = new Vector2(320, 800);
        }

        void OnGUI()
        {
            string resourcePath = GetResourcePath();
            //Debug.LogWarning("resourcePath " + resourcePath);
            Texture2D logo = AssetDatabase.LoadAssetAtPath<Texture2D>(resourcePath + "/EditorWindowIcon.png");
            Rect rect = GUILayoutUtility.GetRect(position.width, logo.height, GUI.skin.box);
            GUI.DrawTexture(rect, logo, ScaleMode.ScaleToFit);

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);

            using (new EditorGUI.DisabledScope(OpenCVForUnityExampleAssetsDownloaderWindow.isDownloadinig))
            {

                EditorGUILayout.LabelField("[Setup for Example Scenes]");

                GUILayout.BeginVertical("box");
                {
                    string aboutText = "Automatically downloads the files needed to run Example Scenes. After downloading, please run \"Move StreamingAssets Folder\".";
                    EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                    if (GUILayout.Button("Open Example Assets Downloader"))
                    {

                        OpenCVForUnityExampleAssetsDownloaderWindow.OpenExampleAssetsDownloaderWindow();
                    }
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("box");
                {
                    string aboutText = "Move the files from the \"OpenCVForUnity/StreamingAssets/\" folder to the \"Assets/StreamingAssets\" folder.";
                    EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                    if (GUILayout.Button("Move StreamingAssets Folder"))
                    {

                        MoveStreamingAssetsFolder();
                    }
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("box");
                {
                    string aboutText = "Add Example Scenes to \"Scenes In Build\" in BuildSettings.";
                    EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                    if (GUILayout.Button("Add Example Scenes In Build"))
                    {

                        AddExampleScenesInBuild();
                    }
                }
                GUILayout.EndVertical();

                EditorGUILayout.Space();

                EditorGUILayout.LabelField("[Optional]");

                GUILayout.BeginVertical("box");
                {
                    string aboutText = "Set the appropriate ImportSettings for the files in the Plugins folder. Please reconfigure when you change the version of UnityEditor.";
                    EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);

                    if (GUILayout.Button("Set Plugin Import Settings"))
                    {

                        OpenCVForUnityMenuItem.SetPluginImportSettings();
                    }
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("box");
                {
                    string aboutText = "Import when using plugins that exclude opencv_contrib modules to reduce build size. See ReadMe.pdf for more information.";
                    EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                    if (GUILayout.Button("Import Extra Package"))
                    {

                        OpenCVForUnityMenuItem.ImportExtraPackage();
                    }
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("box");
                {

                    if (OpenCVForUnityMenuItem.ValidateUseUnsafeCode())
                    {
                        string aboutText = "Remove \"OPENCV_USE_UNSAFE_CODE\" to ScriptCompilationDefines in BuildSettings.";
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Disable Use Unsafe Code"))
                        {

                            OpenCVForUnityMenuItem.UseUnsafeCode(false);
                        }
                    }
                    else
                    {
                        string aboutText = "Add \"OPENCV_USE_UNSAFE_CODE\" to ScriptCompilationDefines in BuildSettings.";
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Enable Use Unsafe Code"))
                        {

                            OpenCVForUnityMenuItem.UseUnsafeCode(true);
                        }

                    }
                }
                GUILayout.EndVertical();

                EditorGUILayout.Space();

                EditorGUILayout.LabelField("[WebGL Settings]");

                GUILayout.BeginVertical("box");
                {

                    if (OpenCVForUnityMenuItem.ValidateUseWebGLThreadsSupport())
                    {
                        string aboutText = "PlayerSettings.WebGL.threadsSupport : "+ PlayerSettings.WebGL.threadsSupport;
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Disable MultiThreads Support"))
                        {

                            OpenCVForUnityMenuItem.UseWebGLThreadsSupport(false);
                        }
                    }
                    else
                    {
                        string aboutText = "PlayerSettings.WebGL.threadsSupport : " + PlayerSettings.WebGL.threadsSupport;
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Enable MultiThreads Support"))
                        {

                            OpenCVForUnityMenuItem.UseWebGLThreadsSupport(true);
                        }

                    }
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("box");
                {

                    if (OpenCVForUnityMenuItem.ValidateUseWebGLSIMDSupport())
                    {
                        string aboutText = "PlayerSettings.WebGL.emscriptenArgs : " + PlayerSettings.WebGL.emscriptenArgs;
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Disable SIMD Support"))
                        {

                            OpenCVForUnityMenuItem.UseWebGLSIMDSupport(false);
                        }
                    }
                    else
                    {
                        string aboutText = "PlayerSettings.WebGL.emscriptenArgs : " + PlayerSettings.WebGL.emscriptenArgs;
                        EditorGUILayout.LabelField(aboutText, EditorStyles.textArea);
                        if (GUILayout.Button("Enable SIMD Support"))
                        {

                            OpenCVForUnityMenuItem.UseWebGLSIMDSupport(true);
                        }

                    }
                }
                GUILayout.EndVertical();

            }

            EditorGUILayout.EndScrollView();
        }

        void OnInspectorUpdate()
        {
            Repaint();
        }

        private string GetResourcePath()
        {
            MonoScript ms = MonoScript.FromScriptableObject(this);
            string path = AssetDatabase.GetAssetPath(ms);

            return path.Substring(0, path.LastIndexOf('/'));
        }

        private string GetStreamingAssetsFolderPath()
        {
            MonoScript ms = MonoScript.FromScriptableObject(this);
            string path = AssetDatabase.GetAssetPath(ms);

            return path.Substring(0, path.LastIndexOf("/Editor/EditorWindow")) + "/StreamingAssets";
        }

        private void MoveStreamingAssetsFolder()
        {
            //Only the AssetDatabase class is used for file operations, not the File.IO class.

            //Debug.Log("GetStreamingAssetsFolderPath() " + GetStreamingAssetsFolderPath());
            string OPENCVFORUNITY_STREAMINGASSETS_PATH = GetStreamingAssetsFolderPath();
            //string OPENCVFORUNITY_STREAMINGASSETS_PATH = "Assets/OpenCVForUnity/StreamingAssets";
            string EDITOR_STREAMINGASSETS_PATH = "Assets/StreamingAssets";

            int errorFileCount = 0;

            string[] guids = AssetDatabase.FindAssets(null, new string[] { OPENCVFORUNITY_STREAMINGASSETS_PATH });
            string[] paths = guids.Select(guid => AssetDatabase.GUIDToAssetPath(guid)).ToArray();
            //Debug.Log($"Search Results:\n{string.Join("\n", paths)}");

            if (paths.Length == 0)
            {
                EditorUtility.DisplayDialog("Finished", "There are no files to move.", "OK");
                return;
            }

            if (!AssetDatabase.IsValidFolder(EDITOR_STREAMINGASSETS_PATH))
            {

                string result = AssetDatabase.ValidateMoveAsset(OPENCVFORUNITY_STREAMINGASSETS_PATH, EDITOR_STREAMINGASSETS_PATH);
                //Debug.Log("AssetDatabase.ValidateMoveAsset " + result);
                if (result == "")
                {

                    if (AssetDatabase.MoveAsset(OPENCVFORUNITY_STREAMINGASSETS_PATH, EDITOR_STREAMINGASSETS_PATH) == "")
                    {
                        //Debug.Log("AssetDatabase.MoveAsset " + EDITOR_STREAMINGASSETS_PATH);

                        paths = null;
                    }
                    else
                    {
                        string[] splitPath = EDITOR_STREAMINGASSETS_PATH.Split('/');

                        if (AssetDatabase.CreateFolder(splitPath[0], splitPath[1]) != "")
                        {
                            //Debug.Log("succes AssetDatabase.CreateFolder " + splitPath[0] + "/" + splitPath[1]);
                        }
                    }
                }

            }

            if (paths != null)
            {
                for (int i = 0; i < paths.Length; i++)
                {
                    string path = paths[i];

                    //Debug.Log("AssetDatabase.IsValidFolder(path) " + AssetDatabase.IsValidFolder(path) + " " + path);

                    if (AssetDatabase.IsValidFolder(path))
                    {
                        string newFolderPath = EDITOR_STREAMINGASSETS_PATH + "/" + path.Substring(OPENCVFORUNITY_STREAMINGASSETS_PATH.Length + 1);
                        //Debug.Log("newFolderPath " + newFolderPath); 

                        if (!AssetDatabase.IsValidFolder(newFolderPath))
                        {
                            string result = AssetDatabase.ValidateMoveAsset(path, newFolderPath);
                            //Debug.Log("AssetDatabase.ValidateMoveAsset " + result);
                            if (result == "")
                            {
                                if (AssetDatabase.MoveAsset(path, newFolderPath) == "")
                                {
                                    //Debug.Log("AssetDatabase.MoveAsset " + newFolderPath);
                                    for (int p = i+1; p < paths.Length; p++)
                                    {
                                        //Debug.Log("Check SkipFile " + paths[p]);
                                        if (!paths[p].StartsWith(path)) break;
                                        i++;
                                        //Debug.Log("SkipFile " + paths[p]);
                                    }
                                    continue;
                                }
                                else
                                {
                                    string parentFolder = newFolderPath.Substring(0, newFolderPath.LastIndexOf('/'));
                                    string folderName = newFolderPath.Substring(newFolderPath.LastIndexOf('/') + 1);

                                    if (AssetDatabase.CreateFolder(parentFolder, folderName) != "")
                                    {
                                        //Debug.Log("succes AssetDatabase.CreateFolder " + parentFolder + "/" + folderName);
                                    }

                                }
                            }
                        }                           
                        
                    }
                    else
                    {

                        string newPath = EDITOR_STREAMINGASSETS_PATH + "/" + path.Substring(OPENCVFORUNITY_STREAMINGASSETS_PATH.Length + 1);
                        //Debug.Log("newPath " + newPath);

                        string result = AssetDatabase.ValidateMoveAsset(path, newPath);
                        //Debug.Log("AssetDatabase.ValidateMoveAsset " + result);
                        if (result == "")
                        {

                            if (AssetDatabase.MoveAsset(path, newPath) == "")
                            {
                                //Debug.Log("AssetDatabase.MoveAsset " + newPath);
                            }
                            else
                            {
                                errorFileCount++;
                            }
                        }
                        else
                        {
                            if (AssetDatabase.MoveAssetToTrash(newPath))
                            {
                                //Debug.Log("AssetDatabase.MoveAssetToTrash " + newPath);
                                if (AssetDatabase.MoveAsset(path, newPath) == "")
                                {
                                    //Debug.Log("AssetDatabase.MoveAsset " + newPath);
                                }
                                else
                                {
                                    errorFileCount++;
                                }
                            }
                            else
                            {
                                errorFileCount++;
                            }
                        }
                    }
                }
            }

            if (errorFileCount == 0)
            {
                if (AssetDatabase.MoveAssetToTrash(OPENCVFORUNITY_STREAMINGASSETS_PATH))
                {
                    //Debug.Log("AssetDatabase.MoveAssetToTrash " + OPENCVFORUNITY_STREAMINGASSETS_PATH);
                }

                EditorUtility.DisplayDialog("Finished", "All files were successfully moved.", "OK");
                
            }
            else
            {
                if (errorFileCount < 2)
                {
                    EditorUtility.DisplayDialog("Finished", "Failed to move " + errorFileCount + " file.", "OK");
                }
                else
                {
                    EditorUtility.DisplayDialog("Finished", "Failed to move " + errorFileCount + " files.", "OK");
                }
            }

            AssetDatabase.Refresh();

        }

        private string GetExamplesFolderPath()
        {
            MonoScript ms = MonoScript.FromScriptableObject(this);
            string path = AssetDatabase.GetAssetPath(ms);

            return path.Substring(0, path.LastIndexOf("/Editor/EditorWindow")) + "/Examples";
        }

        private void AddExampleScenesInBuild()
        {
            //Only the AssetDatabase class is used for file operations, not the File.IO class.

            List<string> pathList = new List<string>();

            string OPENCVFORUNITY_EXAMPLES_PATH = GetExamplesFolderPath();
            //Debug.Log("GetExamplesFolderPath() " + GetExamplesFolderPath());

            if (AssetDatabase.IsValidFolder(OPENCVFORUNITY_EXAMPLES_PATH))
            {

                pathList.Add(OPENCVFORUNITY_EXAMPLES_PATH + "/OpenCVForUnityExample.unity");
                pathList.Add(OPENCVFORUNITY_EXAMPLES_PATH + "/ShowLicense.unity");
                pathList.Add(OPENCVFORUNITY_EXAMPLES_PATH + "/ShowSystemInfo.unity");

                foreach (var guid in AssetDatabase.FindAssets("t:Scene", new string[] { OPENCVFORUNITY_EXAMPLES_PATH + "/Basic" }))
                {
                    pathList.Add(AssetDatabase.GUIDToAssetPath(guid));
                }

                foreach (var guid in AssetDatabase.FindAssets("t:Scene", new string[] { OPENCVFORUNITY_EXAMPLES_PATH + "/Advanced" }))
                {
                    pathList.Add(AssetDatabase.GUIDToAssetPath(guid));
                }

                foreach (var guid in AssetDatabase.FindAssets("t:Scene", new string[] { OPENCVFORUNITY_EXAMPLES_PATH + "/MainModules" }))
                {
                    pathList.Add(AssetDatabase.GUIDToAssetPath(guid));
                }

                foreach (var guid in AssetDatabase.FindAssets("t:Scene", new string[] { OPENCVFORUNITY_EXAMPLES_PATH + "/ContribModules" }))
                {
                    pathList.Add(AssetDatabase.GUIDToAssetPath(guid));
                }
            }

            if (pathList.Count > 0)
            {

                List<EditorBuildSettingsScene> sceneList = new List<EditorBuildSettingsScene>(EditorBuildSettings.scenes);

                foreach (string path in pathList)
                {
                    //Debug.Log("path " + path);
                    sceneList.Add(new EditorBuildSettingsScene(path, true));
                }

                EditorBuildSettings.scenes = sceneList.ToArray();

                EditorUtility.DisplayDialog("Finished", pathList.Count + " Example Scenes were added to \"Scenes In Build\".", "OK");
            }
            else
            {
                EditorUtility.DisplayDialog("Finished", "Example Scenes cannot be found.", "OK");
            }
        }
    }
}