using System;

class Program
{
    static int BinarySearchRecursive(int[] arr, int target, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            return BinarySearchRecursive(arr, target, mid + 1, right);
        else
            return BinarySearchRecursive(arr, target, left, mid - 1);
    }

    static void Main()
    {
        int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14 };
        int target = 10;
        int result = BinarySearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);
        Console.WriteLine("Index: " + result);
    }
}
