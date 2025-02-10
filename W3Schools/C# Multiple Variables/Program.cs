using System;

namespace MultipleVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int x1, y1, z1;
            x1 = y1 = z1 = 50;
            Console.WriteLine(x1 + y1 + z1);
        }
    }
}