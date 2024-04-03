using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("1", "hi");
            d.Add("2", "hello");
            d.Add("3", "hey");
            d.Add("4", "heoooo");

            // Using KeyCollection and Keys field
            Dictionary<string, string>.KeyCollection keycoll = d.Keys;

            foreach(string s in keycoll)
            {
                Console.WriteLine(s);
            }

            //Using KeyValuePair to iterate
            foreach (KeyValuePair<string, string> kvp in d)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  kvp.Key, kvp.Value);
            }


            // Using KeyCollection and Values field
            Dictionary<string, string>.ValueCollection Valuecoll = d.Values;

            foreach (string s in Valuecoll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
