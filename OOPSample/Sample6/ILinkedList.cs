namespace OOPSample.Sample6
{
    public interface ILinkedList<T>
    {
        void Add(T item);
        void Remove(int index);
        T Get(int index);
        void Insert(int index, T item);
        int GetCount();
    }
}