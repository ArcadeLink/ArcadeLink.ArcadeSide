namespace Models
{
    public class SettingsModel
    {
        public string ApiEndpoint { get; set; }

        public int CameraDevice { get; set; }
        public int LocationId { get; set; }
        public string LocationKey { get; set; }
        
        public MachineSetupModel MachineSetup { get; set; }

        public string QiniuAk { get; set; }
        public string QiniuSk { get; set; }
        public string FileUrl { get; set; }
        public string BucketName { get; set; }
        public float RecordInterval { get; set; }
        public bool MaintainceMode { get; set; }
        public string FFmpegPath { get; set; }
        public string FFmpegTempPath { get; set; }
    }
}