using DesignPatterns.Models;

namespace DesignPatterns.Test
{
    public class ProcessorJson
    {
        public string Process(IJson input)
        {
            return "Processed: " + input.extractData();
        }
    }
}