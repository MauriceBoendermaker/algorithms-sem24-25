using System;

namespace MultidimensionalArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(numbers[0, 2]); // 3

            Console.WriteLine();

            numbers[0, 0] = 100;
            Console.WriteLine(numbers[0, 0]); // 100

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine("Outer loop: " + i);

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(" Inner loop: " + numbers[i, j]);
                }
            }
        }
    }
}