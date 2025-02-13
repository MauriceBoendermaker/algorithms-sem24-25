using System;

namespace Constructors
{
    public class Car
    {
        public string model; // Create a field
        public string color;
        public int year;

        // Create a class constructor
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        public static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969); // Create an object
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
}