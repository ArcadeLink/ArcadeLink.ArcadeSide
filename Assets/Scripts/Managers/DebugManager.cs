using System.IO;
using ANU.IngameDebug.Console;
using UnityEngine;

namespace Managers
{
    public class DebugManager : MonoBehaviour
    {
        private void Start()
        {
            // DebugConsole.Commands.RegisterCommand("static-by-name", "desc", "MyStaticMethod", typeof(MyClass));
            DebugConsole.Commands.RegisterCommand("enable-record-feat", "Flags", "EnableRecordFeature", typeof(DebugFeatureFlagManager));
            DebugConsole.Commands.RegisterCommand("disable-record-feat", "Flags", "DisableRecordFeature", typeof(DebugFeatureFlagManager));
            
            DebugConsole.Commands.RegisterCommand("enable-scan-force-record", "Flags", "EnableScanForceRecord", typeof(ScanDebugManager));
            DebugConsole.Commands.RegisterCommand("disable-scan-force-record", "Flags", "DisableScanForceRecord", typeof(ScanDebugManager));
        }
    }
    
    // [assembly: RegisterDebugCommandTypes(typeof(DebugFeatureFlagManager))]
    
    [DebugCommandPrefix("feature-flag-manager")]
    public class DebugFeatureFlagManager
    {
        [DebugCommand]
        public static void EnableRecordFeature()
        {
            File.WriteAllText($"{Application.persistentDataPath}/record.txt", "true");
        }
        
        [DebugCommand]
        public static void DisableRecordFeature()
        {
            File.WriteAllText($"{Application.persistentDataPath}/record.txt", "false");
        }
        
        [RuntimeInitializeOnLoadMethod]
        private static void InitStatic() 
            => DebugConsole.InstanceTargets.Register(new DebugFeatureFlagManager());
    }
    
    // [assembly: RegisterDebugCommandTypes(typeof(ScanDebugManager))]
    
    [DebugCommandPrefix("scan-debug-manager")]
    public class ScanDebugManager
    {
        [DebugCommand]
        public static void EnableScanForceRecord()
        {
            File.WriteAllText($"{Application.persistentDataPath}/scanRecord.txt", "true");
        }
        
        [DebugCommand]
        public static void DisableScanForceRecord()
        {
            File.WriteAllText($"{Application.persistentDataPath}/scanRecord.txt", "false");
        }
        
        [RuntimeInitializeOnLoadMethod]
        private static void InitStatic() 
            => DebugConsole.InstanceTargets.Register(new ScanDebugManager());
    }
}