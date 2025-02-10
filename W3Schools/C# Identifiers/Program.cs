using System;

namespace Identifiers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Good
            int minutesPerHour = 60;

            // Ok, but not so easy to understand what m actually is
            int m = 70;

            Console.WriteLine(minutesPerHour);
            Console.WriteLine(m);
        }
    }
}