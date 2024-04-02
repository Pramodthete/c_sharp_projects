using System;
using System.Collections;

namespace hash_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key + " " + d.Value);
                Console.WriteLine();
            }

            Hashtable ht2 = Hashtable.Synchronized(ht);

            Console.WriteLine(ht2.IsSynchronized);

            IDictionaryEnumerator myEnumerator = ht2.GetEnumerator();

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            while (myEnumerator.MoveNext())
                Console.WriteLine(myEnumerator.Key + " --> "
                                  + myEnumerator.Value);

            if (ht2.ContainsValue("oracle"))
                Console.WriteLine("HashTable contains the Value");
            else
                Console.WriteLine("HashTable doesn't contain the Value");

            if (ht2.ContainsKey("ora"))
                Console.WriteLine("HashTable contains the key");
            else
                Console.WriteLine("HashTable doesn't contain the key");

            Console.WriteLine("Count: " + ht.Count);



            // Using Keys
            ICollection c = ht2.Keys;

            // Displaying the contents 
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht2[str]);

            // Setting the value associated with key "c" 
            ht2["c"] = "C#";

            Console.WriteLine("\nUpdated Values:");

            // Displaying the contents 
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht2[str]);
        }
    }
}
