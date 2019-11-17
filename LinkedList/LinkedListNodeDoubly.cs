namespace LinkedList
{
    public class LinkedListNodeDoubly<T>
    {
        public T Value;
        public LinkedListNodeDoubly<T> Prev;
        public LinkedListNodeDoubly<T> Next;

        public LinkedListNodeDoubly(T value)
        {
            Value = value;
        }

        public LinkedListNodeDoubly(T value, LinkedListNodeDoubly<T> prev, LinkedListNodeDoubly<T> next)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }
}