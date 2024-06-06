using System;

namespace Models
{
    public class HttpRequestModels
    {
        public class VideoInsertRequest
        {
            public string userId { get; set; }
            public int locationId { get; set; }
            public string url { get; set; }
            public DateTime expiryTime { get; set; }
        }

        public class QueueInsertRequest
        {
            public int locationId { get; set; }
            public string userId { get; set; }
            public int deviceId { get; set; }
        }
        
        public class QueueDeleteRequest
        {
            public int locationId { get; set; }
            public int queueId { get; set; }
            public int deviceId { get; set; }
        }
    }
}