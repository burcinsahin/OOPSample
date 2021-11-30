using System;

namespace OOPSample.Sample6
{
    internal class FixedStack<T> : IStack<T>
    {
        private readonly T[] _stack;
        private int _last;

        public FixedStack(int size)
        {
            _stack = new T[size];
        }

        public T Pop()
        {
            if (_last == 0)
                throw new NotSupportedException("Stack is empty!");

            return _stack[--_last];
        }

        public void Push(T value)
        {
            if (_last == _stack.Length)
                throw new NotSupportedException("Stack is full!");

            _stack[_last] = value;
            _last++;
        }

        public override string ToString()
        {
            var str = "";
            for (var i = _last - 1; i > -1; i--)
            {
                str += $"{_stack[i]}, ";
            }
            return str.Trim().Trim(',');
        }
    }
}