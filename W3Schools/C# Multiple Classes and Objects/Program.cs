using System;

namespace MultipleClassesAndObjects
{
    public class Car
    {
        string color = "red";

        public static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();

            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}