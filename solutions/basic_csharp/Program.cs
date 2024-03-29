using System;

namespace basic_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int age = 24;
            char firstLetter = 'P';
            string name = "Pramod";
            double salary = 400000.500D;
            bool present = false;

            double doubleN = 12345678999999999999;
            //it store like this -> 1.2345679E+19
            float floatNum = 12345678999999999999;
            //it store like this -> 1.2345679E+19
            long longNum   = 9223372036854775807;
            int num = 2147483647;

            Console.WriteLine("double: " + doubleN +" float: " + floatNum + " long: " + longNum + " int: " + num);
            int x, y, z;
            x = y = z = 10;
            Console.WriteLine(x+y*z);
            Console.WriteLine("Age: " + age + ", First Letter: " + firstLetter + ", Name: " + name + ", Salary: " + salary + ", Present: " + present);

            int myInt = 9;
            double myDouble = myInt;// Automatic casting: int to double
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            double myDoub = 9.78;
            int myIn = (int)myDoub;    // Manual casting: double to int
            Console.WriteLine(myDoub);   // Outputs 9.78
            Console.WriteLine(myIn);

        }
    }
}
