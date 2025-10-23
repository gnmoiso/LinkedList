namespace Doubly_List
{
    public class DoublyLinkedList<T>
    {
        private DoublyNode<T>? _head;
        private DoublyNode<T>? _tail;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new DoublyNode<T>(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;
            }
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new DoublyNode<T>(data);
            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }
        }

        public string GetForward()
        {
            var uotput = string.Empty;
            var current = _head;
            while (current != null)
            {
                uotput += $"{current.Data} <=> ";
                current = current.Next;
            }
            return uotput.Substring(0, uotput.Length - 5);
        }

        public string GetBackward()
        {
            var output = string.Empty;
            var current = _tail;
            while (current != null)
            {
                output += $"{current.Data} <=> ";
                current = current.Prev;
            }
            return output.Substring(0, output.Length - 5);
        }

        public void Remove(T data)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        _tail = current.Prev;
                    }

                    break;
                }
                current = current.Next;
            }
        }
    }
}