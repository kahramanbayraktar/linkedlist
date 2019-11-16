namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T> Next;

        public LinkedListNode(T value)
        {
            Value = value;
        }

        public LinkedListNode(T value, LinkedListNode<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}