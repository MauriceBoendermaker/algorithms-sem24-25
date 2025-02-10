using System;

namespace StringConcatenation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);

            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z); // 30

            string a = "10";
            string b = "20";
            string c = a + b;
            Console.WriteLine(c); // 1020
        }
    }
}