namespace DesignPatterns.Models
{
    public class Json : IJson
    {
        public string Data { get; set; }

        public string extractData()
        {
            return Data;
        }
    }
}