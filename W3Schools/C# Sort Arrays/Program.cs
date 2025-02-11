using System;
using System.Linq;

namespace SortArrays
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            Array.Sort(cars);

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Sort an int
            int[] myNums = { 10, 40, 50, 80, 20, 10, 100, 0 };

            Array.Sort(myNums);

            foreach (int num in myNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            // System.Linq Namespace
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max()); // Largers value
            Console.WriteLine(myNumbers.Min()); // Lowest value
            Console.WriteLine(myNumbers.Sum()); // Sum of elements
        }
    }
}