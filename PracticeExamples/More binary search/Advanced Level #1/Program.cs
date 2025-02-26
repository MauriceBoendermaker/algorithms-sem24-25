using System;

class Program
{
    static int BinarySearchString(string[] arr, string target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparison = arr[mid].CompareTo(target);

            if (comparison == 0)
                return mid;

            if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        string[] words = { "apple", "banana", "cherry", "date", "fig", "grape" };
        string target = "apple";
        int result = BinarySearchString(words, target);
        Console.WriteLine("Index: " + result);
    }
}
