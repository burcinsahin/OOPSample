using System;

namespace OOPSample.Sample6
{
    public class FixedQueue<T> : IQueue<T>
    {
        private readonly T[] _queue;
        private bool _isFull;
        private int _first;
        private int _last;

        public FixedQueue(int size)
        {
            _queue = new T[size];
            _isFull = false;
        }

        public T Dequeue()
        {
            if (!_isFull && _first == _last)
                throw new NotSupportedException("Queue is empty!");

            var value = _queue[_first];
            _first++;
            _first %= _queue.Length;
            _isFull = false;
            return value;
        }

        public void Enqueue(T value)
        {
            if (_isFull)
                throw new NotSupportedException("Queue is full!");
            _queue[_last] = value;
            _last++;
            _last %= _queue.Length;

            if (_last == _first)
                _isFull = true;
        }

        public override string ToString()
        {
            var str = "";
            if (!_isFull && _first == _last)
                return str;
            var index = _first;
            do
            {
                str += $"{_queue[index]}, ";
                index++;
                index %= _queue.Length;
            } while (index != _last);
            return str.Trim().Trim(',');
        }
    }
}
