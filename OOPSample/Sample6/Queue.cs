using System;

namespace OOPSample.Sample6
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> _first;
        private Node<T> _last;

        public T Dequeue()
        {
            if (_first == null)
                throw new NotSupportedException("Queue is empty!");
            if (_first == _last)
            {
                _last = null;
            }
            var value = _first.Value;
            _first = _first.Next;
            return value;
        }

        public void Enqueue(T value)
        {
            var node = new Node<T>(value);
            if (_first == null)
                _first = node;
            if (_last == null)
                _last = node;
            else
            {
                _last.Next = node;
                _last = node;
            }
        }

        public override string ToString()
        {
            var str = "";
            var curr = _first;

            if (curr == null)
                return str;
            do
            {
                str += $"{curr.Value}, ";
                curr = curr.Next;
            } while (curr != null);
            return str.Trim().Trim(',');
        }
    }
}
