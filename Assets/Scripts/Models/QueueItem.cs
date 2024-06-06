using System.Collections.Generic;

namespace Models
{
    public class QueueItem
    {
        public int queueId { get; set; }
        public int locationId { get; set; }
        public int machineId { get; set; }
        public bool hasPassed { get; set; }
        public string userId { get; set; }
        public string nickname { get; set; }
        public int cardId { get; set; }
        public string cardUrl { get; set; }
    }
}