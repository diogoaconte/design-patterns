namespace DesignPatterns.Patterns.Adapter
{
    public abstract class AbstractAdapter<R, T>
    {
        protected abstract T Parse(R received);
    }
}