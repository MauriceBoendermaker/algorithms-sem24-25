using System;

namespace SpecialCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            string txt2 = "It\'s alright.";
            Console.WriteLine(txt2);

            string txt3 = "The character \\ is called backslash.";
            Console.WriteLine(txt3);
        }
    }
}