using System;

namespace Inheritance
{
    class Vehicle // base class
    {
        public string brand = "Ford"; // field
        public void honk() // method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle // derived class
    {
        public string modelName = "Mustang"; // field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); // create object

            myCar.honk(); // call the method

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}