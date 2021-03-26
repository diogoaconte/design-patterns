using DesignPatterns.Models;

namespace DesignPatterns.Test
{
    public class ProcessorJson
    {
        public string Process(Json json)
        {
            return "Processed: " + json.Data;
        }
    }
}