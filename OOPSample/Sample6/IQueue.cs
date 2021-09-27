namespace OOPSample.Sample6
{
    internal interface IQueue<T> where T : struct
    {
        T Dequeue();
        void Enqueue(T value);
    }
}