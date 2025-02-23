using System;

namespace SequentialSearch
{
    public class Program
    {
        public static int[] arr = { 0, 3, 4, 5, 6, 7 };

        // Key is the value we are searching for
        public static int SequentialSearch(int[] arr, int key)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SequentialSearch(arr, 6));
        }
    }
}