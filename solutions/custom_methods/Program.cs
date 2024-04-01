using System;

namespace custom_methods
{
    internal class Program
    {
        static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static float Add(float a, float b)
        {
            return a + b;
        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            Hello("Hello Pramod");
            Hello("Hello Vaibhav");
            Hello("Hello Pranav");
            Hello("Hello Prajwal");
            Console.WriteLine(".................");

            Console.WriteLine(Add(3, 50));
            Console.WriteLine(Add(90, 30));
            Console.WriteLine(Add(3.5f, 50.70f));
            Console.WriteLine(Add(3.5f, 50.70f));

            MyMethod(child3: "John", child1: "Liam", child2: "Liam");
        }
    }
}
