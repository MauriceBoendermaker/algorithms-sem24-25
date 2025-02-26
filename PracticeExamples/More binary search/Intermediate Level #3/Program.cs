using System;

class Program
{
    static int BinarySearchDescending(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] > target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] sortedArray = { 20, 18, 15, 12, 10, 5, 1 };
        int target = 18;
        int result = BinarySearchDescending(sortedArray, target);
        Console.WriteLine("Index: " + result);
    }
}
