using System;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head;

        public LinkedList(LinkedListNode<T> node)
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
                    var newNode = new LinkedListNode<T>(value) { Next = node.Next };
                    node.Next = newNode;
                    return;
                }

                node = node.Next;
            }
        }

        public void AddBefore(T value, T existing)
        {
            var node = Head;
            var nodePrev = Head;
            while (node != null)
            {
                if (node.Value.Equals(existing))
                {
                    var newNode = new LinkedListNode<T>(value) { Next = node };
                    nodePrev.Next = newNode;
                    return;
                }

                nodePrev = node;
                node = node.Next;
            }
        }

        public void AddFirst(T value)
        {
            var node = new LinkedListNode<T>(value) { Next = Head };
            Head = node;
        }

        public void AddLast(T value)
        {
            var node = new LinkedListNode<T>(value);

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
                        break;
                    }

                    n = n.Next;
                }
            }
        }

        public void Remove(T value)
        {
            var node = Head;
            var nodePrev = Head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    nodePrev.Next = node.Next;
                    node.Next = null;
                }

                nodePrev = node;
                node = node.Next;
            }
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                var nodeNext = Head.Next;
                Head = null;
                Head = nodeNext;
            }
        }

        public void RemoveLast()
        {
            if (Head != null)
            {
                var node = Head;
                var nodePrev = Head;
                while (node != null)
                {
                    if (node.Next == null)
                    {
                        // Set the reference to the last node to null to actually remove the last node from the linked list.
                        nodePrev.Next = null;
                        return;
                    }

                    nodePrev = node;
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
            //var node = Head;
            //while (node != null)
            //{
            //    node = node.Next;
            //    if (node != null)
            //        node.Next = null;
            //}
        }

        public void Print()
        {
            Console.WriteLine("Values in the linked list:");

            var item = Head;

            while (item != null)
            {
                Console.WriteLine(item.Value.ToString());

                item = item.Next;
            }
        }
    }
}
