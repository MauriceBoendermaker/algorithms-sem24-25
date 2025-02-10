using System;

namespace TypeCasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Casting
            int myInt = 9;
            double myDouble = myInt; // Automatic casting

            Console.WriteLine(myInt); // 9
            Console.WriteLine(myDouble); // 9

            // Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // Manual casting

            Console.WriteLine(myDouble2); // 9.78
            Console.WriteLine(myInt2); // 9

            // Type Conversion Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool3 = true;

            Console.WriteLine(Convert.ToString(myInt3));
            Console.WriteLine(Convert.ToDouble(myInt3));
            Console.WriteLine(Convert.ToInt32(myDouble3));
            Console.WriteLine(Convert.ToString(myBool3));
        }
    }
}