using System;
using System.Collections;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(1, 2);
            list.Add(2, 3);
            list.Add(3, 4);
            list.Add(4, 5);
            list.Add(5, 6);


            foreach (DictionaryEntry s in list)
            {
                Console.WriteLine("Key: "+s.Key+", Value: "+s.Value);
            }


            IDictionaryEnumerator enumeratr = list.GetEnumerator();

            while (enumeratr.MoveNext())
            {
                Console.WriteLine("Key: " + enumeratr.Key + ", Value: " + enumeratr.Value);
            }

            Console.WriteLine("");
        }
    }
}
