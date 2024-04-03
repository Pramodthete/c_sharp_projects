using System;
using System.Collections;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);               
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            list.Remove(0);
            list.RemoveAt(3);

            Console.WriteLine();
            
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine("\nCount: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine("Is Fixed size: "+list.IsFixedSize);
            Console.WriteLine("Is Read Only: " + list.IsReadOnly);
        }
    }
}
