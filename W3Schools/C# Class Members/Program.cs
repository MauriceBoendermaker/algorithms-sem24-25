using System;

namespace ClassMembers
{
    public class MyCarClass
    {
        public string color = "red"; // field
        public int maxSpeed = 200; // field

        public void fullThrottle() // method
        {
            Console.WriteLine("The car is goign as fast as it can!");
        }
    }

    public class Car
    {
        public string color = "red";
        public int maxSpeed = 200;
    }

    public class Car2
    {
        public string color;
        public int maxSpeed;
    }

    public class Car3
    {
        public string model;
        public string color;
        public int year;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // public class Car
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);

            Console.WriteLine();

            // public class Car2
            Car2 myObj2 = new Car2();
            myObj2.color = "red";
            myObj2.maxSpeed = 200;
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj2.maxSpeed);

            Console.WriteLine();

            // public class Car3
            Car3 Ford = new Car3();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car3 Opel = new Car3();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Console.WriteLine();

            // public class MyClass
            MyCarClass myObj3 = new MyCarClass();
            myObj3.fullThrottle();
        }
    }
}