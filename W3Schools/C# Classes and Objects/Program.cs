using System;

namespace ClassesAndObjects
{
    public class Car
    {
        string color = "red";

        public static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}