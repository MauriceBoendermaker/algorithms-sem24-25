using System;

namespace DefaultParameterValue
{
    public class Program
    {
        public static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        public static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("Netherlands");
            MyMethod();
            MyMethod("France");
        }
    }
}