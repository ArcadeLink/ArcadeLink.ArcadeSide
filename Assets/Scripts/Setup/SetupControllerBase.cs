using UnityEngine;

namespace Setup
{
    public abstract class SetupControllerBase : MonoBehaviour
    {
        public abstract void StartSetup();
        public abstract void EndStep();
        
        public abstract int SetupStep { get; set; }
        public abstract bool IsSetupComplete { get; }
    }
}