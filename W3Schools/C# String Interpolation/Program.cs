using System;

namespace StringInterpolation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
    }
}