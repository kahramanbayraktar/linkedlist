using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestsForSingly();
            TestsForDoubly();

            Console.ReadLine();
        }

        static void TestsForSingly()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(3));

            var initialValues = new[] { 4, 5, 1, 7 };
            foreach (var value in initialValues)
            {
                linkedList.AddLast(value);
            }

            linkedList.AddFirst(9);
            linkedList.AddLast(10);
            linkedList.AddAfter(11, 5);
            linkedList.AddBefore(19, 5);

            linkedList.Print();

            linkedList.Remove(5);

            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            //linkedList.Clear();

            linkedList.Print();

            Console.WriteLine("Contains 1: " + linkedList.Contains(1));
        }

        static void TestsForDoubly()
        {
            var linkedList = new LinkedListDoubly<int>(new LinkedListNodeDoubly<int>(3));

            var initialValues = new[] { 4, 5, 1, 7 };
            foreach (var value in initialValues)
            {
                linkedList.AddLast(value);
            }

            linkedList.AddFirst(9);
            linkedList.AddLast(10);
            linkedList.AddAfter(11, 5);
            linkedList.AddBefore(19, 5);

            linkedList.Print();

            linkedList.Remove(5);

            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();

            //linkedList.Clear();

            linkedList.Print();

            Console.WriteLine("Contains 1: " + linkedList.Contains(1));
        }
    }
}
