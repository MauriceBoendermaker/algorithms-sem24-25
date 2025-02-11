using System;

namespace BreakAndContinue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
                if (x == 4)
                {
                    break;
                }
            }

            Console.WriteLine();

            int y = 0;
            while (y < 10)
            {
                if (y == 4)
                {
                    y++;
                    continue;
                }
                Console.WriteLine(y);
                y++;
            }
        }
    }
}