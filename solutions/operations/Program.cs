using System;

namespace operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking input from user in string
            Console.WriteLine("Enter your Name: ");
            string name= Console.ReadLine();

            //taking input from user in int
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(age);

            int x = 5;
            int y = 3;
            Console.WriteLine(x > y);

        }
    }
}
