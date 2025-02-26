using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] unsortedArray = { 36, 2, 29, 1, 8, 14 };

            BubbleSort(unsortedArray);
        }

        public static void BubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - (1 + i); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}