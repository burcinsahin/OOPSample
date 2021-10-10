namespace OOPSample.Sample6
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
    }
}