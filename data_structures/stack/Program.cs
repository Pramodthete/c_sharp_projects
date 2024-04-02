using System;
using System.Collections;
using System.Threading;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create stack object
            Stack myStack = new Stack();

            myStack.Push(1);
            myStack.Push("2");
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);

            Console.WriteLine("Total number of elements in the Stack are : " + myStack.Count);
            
            Console.WriteLine(myStack.Pop());

            Console.WriteLine("Peek element: " + myStack.Peek());

            Console.WriteLine(myStack.Contains(1)); //True

            Console.WriteLine("myStack is {0}.", myStack.IsSynchronized ?
                                "Synchronized" : "Not Synchronized");

            Stack ss = Stack.Synchronized(myStack);
            Console.WriteLine("myStack is {0}.", ss.IsSynchronized ?
                                "Synchronized" : "Not Synchronized");

            //myStack.Clear();
            //Console.WriteLine(myStack.Peek()); //error stack empty

            lock (myStack.SyncRoot) // to avoid errors
            {
                // foreach loop to display 
                // the elements in st 
                foreach (Object i in myStack)
                    Console.WriteLine("-"+i);
            }

            foreach (var i in myStack) // var is correct in diffrent types of values
                Console.WriteLine(i);




            Stack mStack = new Stack();

            // Inserting the elements into the Stack 
            mStack.Push("Geeks");
            mStack.Push("Geeks Classes");
            mStack.Push("Noida");
            mStack.Push("Data Structures");
            mStack.Push("GeeksforGeeks");

            // Creating a string array arr 
            string[] arr = new string[mStack.Count];

            // Copying the elements of 
            // stack into array arr 
            mStack.CopyTo(arr, 0);

            // Displaying the elements 
            // in array arr 
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }



            Stack a= new Stack();
            a = ss;
            Console.WriteLine(ss.Equals(a));



            IEnumerator enumerator = mStack.GetEnumerator();

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the Stack 
            // and MoveNext returns false. 
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
