using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Lesson2
{
    public class Lesson2
    {
        /* --- Recap --- */
        public static void W2Main()
        {
            Console.WriteLine("Week 2");
            var arr = new int[] { 1, 3, 2, 4, 5, 7, 10 };
        }

        public static int Add(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int Multiply(int[] arr)
        {
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }

        public static T Agg<T>(T[] arr, Func<T, T, T> fx)
        {
            if (arr == null || arr.Length <= 0) return default(T);
            T result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                result = fx(result, arr[i]);
            }
            return result;
        }

        public static R Agg<T, R>(T[] arr, Func<R, T, R> fx, R seed)
        {
            if (arr == null || arr.Length <= 0) return default(R);

            R result = seed;
            for (int i = 0; i < arr.Length; i++)
            {
                result = fx(result, arr[i]);
            }
            return result;
        }
        /* --- End of recap --- */

        public static void Sort(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;

            for (int j = 1; j < arr.Length; j++)
            {
                var key = arr[j];

                int i = j - 1;
                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i--;
                }
                arr[i + 1] = key;
            }
        }

        // Bubble Sort (niet compleet)
        public static void BubbleSort(int[] arr)
        {
            bool onceMore = true;
            int numberOfRounds = 0;

            while (onceMore)
            {
                onceMore = false;

                for (int i = 0; i < arr.Length - 1 - numberOfRounds; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        // Swap
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        // (arr[i], arr[i+1]) = (arr[i+1], arr[i]);
                        onceMore = true;
                    }
                    numberOfRounds++;
                }
            }
        }

        // Merge sort -- O(n log n)

        // Split(0,7)
        // sp(0,3) , sp(4,7)
        // sp(0,1) , sp(2, 3) ...
        // sp(0,0) , sp(1,1) <-- base case, so should not happen
        public static void Split(int l, int h)
        {
            // base case
            if (l >= h) return;
            // recursive step
            int m = (l + h) / 2;
            Split(l, m);
            Split(m + 1, h);
        }

        public static int[] Combine(int[] arrPart1, int[] arrPart2)
        {
            // null en 0 check hier
            int finalSize = arrPart1.Length + arrPart2.Length;
            int[] result = new int[finalSize];
            int i = 0; // part 1
            int j = 0; // part 2

            for (int k = 0; k < finalSize; k++)
            {
                if (i < arrPart1.Length && j < arrPart2.Length)
                {
                    if (arrPart1[i] < arrPart2[j])
                    {
                        result[k] = arrPart1[i];
                        i++;
                    }
                    else
                    {
                        result[k] = arrPart2[j];
                        j++;
                    }
                }
                else if (i >= arrPart1.Length)
                {
                    result[k] = arrPart2[j++];
                }
                else
                {
                    result[k] = arrPart1[i++];
                }
            }
            return result;
        }

    }
}