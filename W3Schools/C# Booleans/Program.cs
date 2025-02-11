using System;
using System.Threading.Tasks.Dataflow;

namespace Booleans
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // True

            Console.WriteLine(10 > 9); // True

            int a = 10;
            Console.WriteLine(a == 10); // True

            Console.WriteLine(10 == 15); // False

            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);

            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
        }
    }
}