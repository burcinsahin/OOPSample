namespace OOPSample.Sample6
{
    public interface IStack<T> where T : struct
    {
        void Push(T value);
        T Pop();
    }
}