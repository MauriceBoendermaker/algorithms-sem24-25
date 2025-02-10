using System;

namespace Operators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 100 + 50;
            Console.WriteLine(x);

            int sum1 = 100 + 50; // 150
            int sum2 = sum1 + 250; // 400
            int sum3 = sum2 + sum2; // 800

            Console.WriteLine(sum3); // 800
        }
    }
}