using System.IO;
using UnityEditor;
using UnityEngine;

namespace OpenCVForUnity.Editor
{

    public class OpenCVForUnityProjectSettings : ScriptableObject
    {
        private static OpenCVForUnityProjectSettings _instance;

        public static OpenCVForUnityProjectSettings Instance
        {
            get
            {
                if (_instance == null)
                {

                    string path = GetEditorFolderPath() + "/OpenCVForUnityProjectSettings.asset";
                    _instance = AssetDatabase.LoadAssetAtPath<OpenCVForUnityProjectSettings>(path);

                    if (_instance == null)
                    {
                        _instance = ScriptableObject.CreateInstance<OpenCVForUnityProjectSettings>();
                        _instance.showSetupToolsWindowFlag = true;
                        AssetDatabase.CreateAsset(_instance, path);
                    }
                }

                return _instance;
            }
        }

        public bool showSetupToolsWindowFlag;

        static string GetEditorFolderPath()
        {

            string[] guids = UnityEditor.AssetDatabase.FindAssets("OpenCVForUnityProjectSettings");
            if (guids.Length == 0)
            {
                Debug.LogWarning("OpenCVForUnityProjectSettings.cs is missing.");
                return null;
            }
            string editorFolderPath = AssetDatabase.GUIDToAssetPath(guids[0]).Substring(0, AssetDatabase.GUIDToAssetPath(guids[0]).LastIndexOf("/OpenCVForUnityProjectSettings"));

            //Debug.Log("editorFolderPath " + editorFolderPath);

            return editorFolderPath;
        }
    }
}
