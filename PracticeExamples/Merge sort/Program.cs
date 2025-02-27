using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 1, 8, 1, 5, 7, 11 };
            MergeSort(a, 0, a.Length - 1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.Read();
        }

        private static void MergeSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2 + 1;
                MergeSort(a, l, m - 1);
                MergeSort(a, m, r);
                Merge(a, l, m, r);
            }
        }

        private static void Merge(int[] a, int l, int m, int r)
        {
            int i, j, k;
            int leftArrayLength = m - l;
            int rightArrayLength = r - m + 1;

            int[] left = new int[leftArrayLength];
            int[] right = new int[rightArrayLength];

            for (i = 0; i < leftArrayLength; i++)
            {
                left[i] = a[l + i];
            }

            for (i = 0; i < rightArrayLength; i++)
            {
                right[i] = a[m + i];
            }

            i = 0;
            j = 0;
            k = l;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (left[i] <= right[j])
                {
                    a[k++] = left[i++];
                }
                else
                {
                    a[k++] = right[j++];
                }
            }

            if (i == leftArrayLength)
            {
                for (int ii = j; ii < rightArrayLength; ii++)
                {
                    a[k++] = right[ii];
                }
            }

            if (j == rightArrayLength)
            {
                for (int ii = j; ii < leftArrayLength; ii++)
                {
                    a[k++] = left[ii];
                }
            }
        }
    }
}