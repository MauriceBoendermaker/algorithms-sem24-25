using System;

namespace FinalLevel
{
    public class Program
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
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

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 7, 9, 11, 100, 200 };
            int target = 7;
            int result = BinarySearch(arr, target);

            Console.WriteLine("Index: " + result);
        }
    }
}