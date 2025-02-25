using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 69, 4, 2, 10, 50, 3, 7, 9, 22, 8, 0, 100 };

            InsertionSort(arr);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void InsertionSort(int[] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];

                int i = j - 1;
                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
        }
    }
}