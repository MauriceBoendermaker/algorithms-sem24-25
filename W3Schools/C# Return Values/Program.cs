using System;

namespace ReturnValues
{
    public class Program
    {
        public static int MyMethod(int x, int y)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }
    }
}