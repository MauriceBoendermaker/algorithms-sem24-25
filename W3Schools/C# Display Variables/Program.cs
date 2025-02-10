using System;

namespace DisplayVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);
        }
    }
}