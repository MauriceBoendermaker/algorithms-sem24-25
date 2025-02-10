using System;

namespace UserInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);


            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}