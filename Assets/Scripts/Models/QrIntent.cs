namespace Models
{
    public class QrIntent
    {
        public Intents Intent { get; set; }
        public string UserId { get; set; }
    }

    public enum Intents
    {
        record,
        scan,
        static_card
    }
}