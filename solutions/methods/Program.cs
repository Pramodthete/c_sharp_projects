using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we don't need to import Math class beacause its already in System namespace
            int highestValue=Math.Max(10, 20);
            int lowestValue= Math.Min(10, 20);

            // this Sqrt, Abs, Round methods returns = double value
            double root = Math.Sqrt(13);

            double absolute = Math.Abs(root);

            double roundValue = Math.Round(absolute);

            Console.WriteLine("max value: "+highestValue);
            Console.WriteLine("min value: "+lowestValue);
            Console.WriteLine("absolute value: "+ absolute);
            Console.WriteLine("square root value: "+ root);
            Console.WriteLine("round value: "+ roundValue);


            //Strings
            string myString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // to find length of string
            Console.WriteLine(myString.Length);

            // make it Lower case
            Console.WriteLine("Lower: "+myString.ToLower());
            // make it Upper case
            Console.WriteLine("Upper: " + myString.ToUpper());

            // concating string 2 methods
            string firstName = "John ";
            string lastName = "Doe";
            string name1 = string.Concat(firstName, lastName);
            string name2 = firstName + lastName;
            Console.WriteLine(name1+" \n"+name2);

            //used interpolation
            string fullname = $"Interpolation : Full Name is {firstName} {lastName}";
            Console.WriteLine(fullname);

            // print single character of string
            string myStr = "Hello";
            Console.WriteLine(myStr[0]);

            //used indexOf method
            int index = myStr.IndexOf('e');
            Console.WriteLine(index);


            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lName);

        }
    }
}
