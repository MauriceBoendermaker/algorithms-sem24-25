using System;

namespace LoopThroughArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine();

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}