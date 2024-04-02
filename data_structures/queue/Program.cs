using System;
using System.Collections;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue object from Collections namespace
            Queue q = new Queue();

            q.Enqueue("hii");
            q.Enqueue("helloo");
            q.Enqueue("Bye");
            q.Enqueue("by");
            q.Enqueue("Good Bye");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count: "+q.Count);

            Console.WriteLine(q.Contains("Bye"));
            Console.WriteLine("Peek a element: "+q.Peek());


            // To Array Conversion
            Object[] arr = q.ToArray();
            Console.WriteLine("\nConverted Array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            // Make Queue Synchronized
            Queue q2 = Queue.Synchronized(q);

            Console.WriteLine("q2: "+q2.IsSynchronized);
            Console.WriteLine("q: "+q.IsSynchronized);


            q.Dequeue();

            Console.WriteLine("element deleted........\nUsing Enumerator: ");
            IEnumerator enumerator = q2.GetEnumerator(); // System.Collections namespace

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the Queue 
            // and MoveNext returns false. 
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
    }
}
