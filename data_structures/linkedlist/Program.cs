using System;
using System.Collections;
using System.Collections.Generic;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>(); 

            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First element: "+list.First.Value);
            Console.WriteLine(list.Contains("b"));

            Console.WriteLine("Total nodes in myList are : " + list.Count);
            list.Remove(list.First);
            Console.WriteLine("Remove(list.First) -> first node deleted............");
            Console.WriteLine("Total nodes in myList are : " + list.Count);


            // Array
            string[] myArr = new string[5];

            // Copying LinkedList to Array, 
            // starting at the specified index 
            // of the target array 
            list.CopyTo(myArr, 0);

            // Displaying elements in array myArr 
            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }

            list.RemoveLast();
            Console.WriteLine("Used RemoveLast() method.....");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("TOtal count : {0}",
                                         list.Count);
            // After using Clear() method
            list.Clear();
            Console.WriteLine("Used Clear() method.....");
            Console.WriteLine("TOtal count : {0}",
                                         list.Count);

        }
    }
}
