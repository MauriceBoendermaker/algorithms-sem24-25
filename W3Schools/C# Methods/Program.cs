using System;

namespace Methods
{
    public class Program
    {
        public static void MyMethod()
        {
            Console.WriteLine("I just got printed in the console!");
        }

        public static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }
    }
}