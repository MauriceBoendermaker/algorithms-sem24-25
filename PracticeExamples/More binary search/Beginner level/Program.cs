using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13 };
        int target = 13;
        int result = BinarySearch(sortedArray, target);
        Console.WriteLine("Index: " + result);
    }
}
