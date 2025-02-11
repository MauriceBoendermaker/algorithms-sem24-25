using System;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] myNum = { 10, 20, 30, 40 };

            Console.WriteLine(cars[0]); // Volvo

            Console.WriteLine();

            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

            Console.WriteLine();

            Console.WriteLine(cars.Length); // 4

            Console.WriteLine();

            string[] fastCars = new string[4] { "Ferrari", "Porsche", "Lamborghini", "Koenigsegg" };

            foreach (string car in fastCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}