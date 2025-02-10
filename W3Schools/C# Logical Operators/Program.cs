using System;

namespace LogicalOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine(x < 11 && y < 11);

            int a = 10;
            int b = 35;
            Console.WriteLine(a > 2 || b < 40);
        }
    }
}