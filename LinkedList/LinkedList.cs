﻿using System;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private int _length;

        public LinkedListNode<T> Head;
        public LinkedListNode<T> Tail;
        
        public LinkedList(LinkedListNode<T> node)
        {
            Head = node;
            _length++;
        }

        public LinkedList()
        {
            
        }

        public LinkedList(T value)
        {
            Head = new LinkedListNode<T>(value);
            _length++;
        }

        public LinkedList(T[] values)
        {
            foreach (var value in values)
            {
                AddLast(value);
            }
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
                    _length++;
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
                    _length++;
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
            _length++;
        }

        public void AddLast(T value)
        {
            var node = new LinkedListNode<T>(value);

            if (Head == null)
            {
                Head = node;
                _length++;
            }
            else
            {
                var n = Head;
                while (n != null)
                {
                    if (n.Next == null)
                    {
                        n.Next = node;
                        _length++;
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
                    _length--;
                    return;
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
                _length--;
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
                        _length--;
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
            _length = 0;


            // TODO: Necessary?
            //var node = Head;
            //while (node != null)
            //{
            //    node = node.Next;
            //    if (node != null)
            //        node.Next = null;
            //}
        }

        public int Length()
        {
            return _length;
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
