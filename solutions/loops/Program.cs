using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENter two numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else if(y > x)
            {
                Console.WriteLine($"{y} is greater than {x}");
            }
            else
            {
                Console.WriteLine("Both NUmbers are equal");
            }

            // Short Hand If else (Ternary) -> condition ? true : false;
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            Console.WriteLine("Enter the Age");
            //switch case
            int age=Convert.ToInt32(Console.ReadLine());

            switch(age)
            {
                case 18: Console.WriteLine($"Age is {age}");
                break;

                case 21: Console.WriteLine($"Age is {age}");
                break;

                case 45:
                    Console.WriteLine($"Age is {age}");
                    break;

                case 60:
                    Console.WriteLine($"Age is {age}");
                    break;

                case 20:
                    Console.WriteLine($"Age is {age}");
                    break;

                case 24:
                    Console.WriteLine($"Age is {age}");
                    break;
            }


            //While Loop
            while (age>18 && age<=50)
            {
                Console.Write(age % 10 == 0 ? $"{age} " : "");
                age++;
            }

            Console.Write("\nENter num for pattern: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //For Loop
            for (int i=1; i <=num; i++)
            {
                for (int j = i; j <= num; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Iterate array using foreach loop: ");
            // array iterate with foreach loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("While with break and continue");
            // break and continue
            int k = 0;
            while ( k != 50 )
            {
                if (k == 11)
                {
                    continue;
                }
                Console.Write($"{k}");
                if (k == 24)
                {
                    break;
                }
                k++;
            }
        }
    }
}
