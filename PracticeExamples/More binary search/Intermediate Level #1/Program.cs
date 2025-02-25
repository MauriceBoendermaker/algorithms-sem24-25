using System;

class Program
{
    static int BinarySearch(double[] arr, double target)
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
        double[] sortedArray = { 1.2, 3.4, 5.6, 7.8, 9.0 };
        double target = 7.8;
        int result = BinarySearch(sortedArray, target);
        Console.WriteLine("Index: " + result);
    }
}
