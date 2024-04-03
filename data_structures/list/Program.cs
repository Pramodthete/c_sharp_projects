using System;
using System.Collections.Generic;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            int p = 0;

            // Displaying the elements of List 
            foreach (string k in list)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine("Capacity Is: " + list.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + list.Count);

            Console.WriteLine("");
        }
    }
}
