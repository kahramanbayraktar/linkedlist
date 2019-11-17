using System;

namespace LinkedList
{
    public class LinkedListDoubly<T>
    {
        public LinkedListNodeDoubly<T> Head;

        public LinkedListDoubly(LinkedListNodeDoubly<T> node)
        {
            Head = node;
        }

        public void AddAfter(T value, T existing)
        {
            var node = Head;
            while (node != null)
            {
                if (node.Value.Equals(existing))
                {
                    var newNode = new LinkedListNodeDoubly<T>(value) { Prev = node, Next = node.Next };
                    node.Next = newNode;
                    return;
                }

                node = node.Next;
            }
        }

        public void AddBefore(T value, T existing)
        {
            var node = Head;
            while (node != null)
            {
                if (node.Value.Equals(existing))
                {
                    var newNode = new LinkedListNodeDoubly<T>(value) { Prev = node.Prev, Next = node };
                    node.Prev.Next = newNode;
                    return;
                }

                node.Prev = node;
                node = node.Next;
            }
        }

        public void AddFirst(T value)
        {
            var node = new LinkedListNodeDoubly<T>(value) { Prev = null, Next = Head };
            Head.Prev = node;
            Head = node;
        }

        public void AddLast(T value)
        {
            var node = new LinkedListNodeDoubly<T>(value);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var n = Head;
                while (n != null)
                {
                    if (n.Next == null)
                    {
                        n.Next = node;
                        node.Prev = n;
                        break;
                    }

                    n = n.Next;
                }
            }
        }

        public void Remove(T value)
        {
            var node = Head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    node.Prev.Next = node.Next;
                    node.Next.Prev = node.Prev; // TODO: ?
                    node.Next = null; // TODO: ?
                }

                node.Prev = node;
                node = node.Next;
            }
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                var nodeNext = Head.Next;
                nodeNext.Prev = null;
                Head = null;
                Head = nodeNext;
            }
        }

        public void RemoveLast()
        {
            if (Head != null)
            {
                var node = Head;
                while (node != null)
                {
                    if (node.Next == null)
                    {
                        // Set the reference to the last node to null to actually remove the last node from the linked list.
                        node.Prev.Next = null;
                        return;
                    }

                    node.Prev = node;
                    node = node.Next;
                }
            }
        }

        public bool Contains(T value)
        {
            var node = Head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    return true;
                }

                node = node.Next;
            }

            return false;
        }

        public void Clear()
        {
            Head = null;

            // TODO: Necessary?
            var node = Head;
            while (node != null)
            {
                node = node.Next;
                if (node != null)
                {
                    node.Prev = null;
                    node.Next = null;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Values in the doubly linked list:");

            var item = Head;

            while (item != null)
            {
                Console.WriteLine(item.Value.ToString());

                item = item.Next;
            }
        }
    }
}
