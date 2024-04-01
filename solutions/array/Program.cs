using System;
using System.Linq;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an array of four elements, and add values later
            string[] c = new string[4];

            // Create an array of four elements and add values right away 
            string[] ca = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] car = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());
            Console.WriteLine(myNumbers.Length);

            //The single comma [,] specifies that the array is two-dimensional.
            //A three-dimensional array would have two commas: int[,,].
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }
    }
}
