using DesignPatterns.Patterns.Adapter;

namespace DesignPatterns.Test
{
    public class ProcessorJson
    {
        public string Process(IJson json)
        {
            return "Processed: " + json.Json().Data;
        }
    }
}