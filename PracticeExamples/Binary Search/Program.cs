using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 21 };
            int target = 4;

            Console.WriteLine(BinarySearch(numbers, target));
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
