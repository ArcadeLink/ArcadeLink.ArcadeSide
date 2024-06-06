using System.IO;
using UnityEngine;

namespace Managers
{
    public partial class FeatureFlagManager
    {
        public static bool IsFeatureEnabled(string featureName)
        {
            return bool.Parse(File.ReadAllText($"{Application.persistentDataPath}/{featureName}.txt"));
        }
        
        public static bool IsScanForceRecordEnabled()
        {
            if (!File.Exists($"{Application.persistentDataPath}/scanRecord.txt"))
            {
                return false;
            }
            
            
            return bool.Parse(File.ReadAllText($"{Application.persistentDataPath}/scanRecord.txt"));
        }
    }
}