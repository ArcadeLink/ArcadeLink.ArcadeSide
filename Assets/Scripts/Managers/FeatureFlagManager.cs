using System.IO;
using UnityEngine;

namespace Managers
{
    public abstract class FeatureFlagManager
    {
        public static bool IsFeatureEnabled(string featureName)
        {
            var path = $"{Application.persistentDataPath}/{featureName}.txt";
            return File.Exists(path) && bool.Parse(File.ReadAllText(path));
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