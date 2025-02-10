using System;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello";
            Console.WriteLine(greeting);

            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting2);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());
        }
    }
}