using System;

class Program
{
    static int BinarySearchFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = result - 1; // Keep searching left
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static void Main()
    {
        int[] sortedArray = { 1, 2, 3, 3, 3, 7, 9, 9, 11 };
        int target = 9;
        int result = BinarySearchFirstOccurrence(sortedArray, target);
        Console.WriteLine("First Occurrence Index: " + result);
    }
}
