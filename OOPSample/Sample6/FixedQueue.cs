using System;

namespace OOPSample.Sample6
{
    internal class FixedQueue<T> : IQueue<T> where T : struct
    {
        private readonly T[] _queueArr;
        private bool _isFull;
        private int _first;
        private int _last;

        public FixedQueue(int size)
        {
            _queueArr = new T[size];
            _isFull = false;
        }

        public T Dequeue()
        {
            if (!_isFull && _first == _last)
                throw new NotSupportedException("Queue is empty!");

            var value = _queueArr[_first];
            _first++;
            _first %= _queueArr.Length;
            _isFull = false;
            return value;
        }

        public void Enqueue(T value)
        {
            if (_isFull)
                throw new NotSupportedException("Queue is full!");
            _queueArr[_last] = value;
            _last++;
            _last %= _queueArr.Length;

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
                str += $"{_queueArr[index]}, ";
                index++;
                index %= _queueArr.Length;
            } while (index != _last);
            return str.Trim().Trim(',');
        }
    }
}
