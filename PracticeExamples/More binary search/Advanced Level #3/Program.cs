using System;

class Program
{
    static int SearchInRotatedArray(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[left] <= arr[mid]) // Left half is sorted
            {
                if (target >= arr[left] && target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else // Right half is sorted
            {
                if (target > arr[mid] && target <= arr[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] rotatedArray = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 4;
        int result = SearchInRotatedArray(rotatedArray, target);
        Console.WriteLine("Index: " + result);
    }
}
