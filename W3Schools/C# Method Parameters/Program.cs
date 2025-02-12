using System;

namespace MethodParameters
{
    public class Program
    {
        public static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " Refsnes is " + age);
        }

        public static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}