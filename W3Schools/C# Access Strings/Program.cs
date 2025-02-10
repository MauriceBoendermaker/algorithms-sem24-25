using System;

namespace AccessStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]); // H
            Console.WriteLine(myString[1]); // e

            Console.WriteLine(myString.IndexOf("e")); // 1


            string name = "John Doe";

            int charPos = name.IndexOf("D");

            string lastName = name.Substring(charPos);

            Console.WriteLine(lastName);
        }
    }
}