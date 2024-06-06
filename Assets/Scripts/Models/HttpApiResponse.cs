namespace Models
{
    public class HttpApiResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}