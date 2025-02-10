using System;

namespace DataTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            float f1 = 35e3F;
            double d1 = 12E4D;

            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}