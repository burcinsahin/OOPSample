using System;

namespace OOPSample.Sample6
{
    public class Stack<T> : IStack<T>
    {
        Node<T> _last;

        public T Pop()
        {
            if (_last == null)
            {
                throw new NotSupportedException("Stack is empty!");
            }

            var val = _last.Value;
            _last = _last.Next;
            return val;
        }

        public void Push(T value)
        {
            if (_last == null)
                _last = new Node<T>(value);
            else
            {
                var node = new Node<T>(value);
                node.Next = _last;
                _last = node;
            }
        }

        public override string ToString()
        {
            var str = "";
            var curr = _last;
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
