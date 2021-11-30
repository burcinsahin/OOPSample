namespace OOPSample.Sample6
{
    public class LinkedList<T> : ILinkedList<T>
    {
        internal Node<T> _first;
        internal Node<T> _last;
        private int _count;

        public LinkedList()
        {
        }

        public void Add(T item)
        {
            var node = new Node<T>(item);

            if (_first == null)
            {
                _first = node;
                _last = _first;
            }
            else
            {
                _last.Next = node;
                _last = node;
            }
            _count++;
        }

        public T Get(int index)
        {
            var node = GetNode(index);

            return node.Value;
        }

        protected Node<T> GetNode(int index)
        {
            var node = _first;
            for (var i = 0; i < index; i++)
            {
                node = node.Next;
                if (node == null)
                    throw new System.IndexOutOfRangeException();
            }

            return node;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                var temp = _first;
                _first = new Node<T>(item);
                _first.Next = temp;
            }
            else
            {
                var node = GetNode(index - 1);
                var temp = node.Next;
                node.Next = new Node<T>(item);
                node.Next.Next = temp;
            }
            _count++;
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                _first = _first.Next;
            }
            else
            {
                var node = GetNode(index - 1);
                node.Next = node?.Next?.Next;
            }
            _count--;
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

        public int GetCount()
        {
            return _count;
        }
    }
}
