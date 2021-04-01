using DesignPatterns.Models;

namespace DesignPatterns.Patterns.Adapter
{
    public interface IJsonAdapter
    {
        Json ToJson();
    }
}