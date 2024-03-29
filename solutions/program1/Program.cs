using System;
// this is the System namespace we are using predefined functionality 

namespace program1
{// this is our custom namespaces
    internal class Program
    { // default access modifier is internal which only acess in same namespace or same essembly
        static void Main(string[] args) // this is main starting point of program
        {
            //Console os a class and WriteLine is a method of that class
            // and method take 1 argument and show it on console
            Console.WriteLine("This is Project 1");

            Console.Write("Hello");
            Console.Write(", I am a diffrent print statement but in same line\n");

            //we can also pass expression it will execute with BODMAS rule
            Console.WriteLine(3 + 5 * 2);

            // This is a comment which is sigle line comment
            // comments are only for developers to make code more readable

            /* and this is multiline comment
             *  we can write more than one lines
             */
        }
    }
}
