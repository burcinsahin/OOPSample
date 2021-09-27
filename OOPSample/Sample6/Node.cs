namespace OOPSample.Sample6
{
    internal class Node<T> 
    {
        private readonly T _value;

        public Node(T value)
        {
            _value = value;
        }

        private Node<T> _next;

        public T Value => _value;

        internal Node<T> Next { get => _next; set => _next = value; }
    }
}
