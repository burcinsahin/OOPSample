namespace OOPSample.Sample6
{
    public interface IQueue<T>
    {
        T Dequeue();
        void Enqueue(T value);
    }
}