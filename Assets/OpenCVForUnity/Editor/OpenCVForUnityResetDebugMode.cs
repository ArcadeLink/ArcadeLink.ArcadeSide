#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.Editor
{
    public class OpenCVForUnityResetDebugMode : MonoBehaviour
    {

        [InitializeOnEnterPlayMode]
        static void InitializeOnEnterPlayMode()
        {

            Utils.setDebugMode(false);

        }
    }
}
#endif