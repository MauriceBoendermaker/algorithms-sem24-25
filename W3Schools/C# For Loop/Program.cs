using System;

namespace ForLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // Outer loop
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Outer: " + i);

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);
                }
            }
        }
    }
}