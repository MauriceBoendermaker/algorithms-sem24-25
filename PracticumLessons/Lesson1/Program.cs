using System;
using System.Configuration.Assemblies;
using System.Numerics;

namespace Lesson1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello");

            var arr = new int[] { 1, 2, 3, 4, 5, 7, 8, -5, 5, 4, 3, 22, 2 };
            var arr2 = new string[] { "alpha", "bravo", "charlie" };

            Console.WriteLine(FindNumber(arr, -5));
            Console.WriteLine(Find<int>(arr, -5));
            Console.WriteLine(Find(arr2, "bravo"));

            var recordarr = new abc[] { new(1, "one"), new(2, "two") };
            var classarr = new xyz[] { new(1, "one"), new(2, "two") };

            var rk = new abc(1, "one");
            var ck = new xyz(1, "One");
            Console.WriteLine(Find(recordarr, rk));
            Console.WriteLine(Find(classarr, ck));

            Console.WriteLine(BinarySearch(arr, 7));

            int [,]NDArray = new int [,]{{1, 2, 3}, {4, 5, 6}};
            int [][]JaggedArray = new int [][]
            {
                new int [] {1, 2, 3, 4},
                new int [] {4, 5, 6},
                new int[] {},
                null
                };
            Console.WriteLine(NDArray);
            Console.WriteLine(JaggedArray);
        }

        static int FindNumber(int[] arr, int key)
        {
            if (arr == null || arr.Length == 0) return -1;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        static int Find<T>(T[] arr, T key) where T : IEquatable<T>
        {
            if (arr == null || arr.Length == 0) return -1;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i]!.Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }

        static int BinarySearch<T>(T[] arr, T key) where T : IComparable<T>
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (key.CompareTo(arr[middle]) == 0) return middle;
                if (key.CompareTo(arr[middle]) < 0) high = middle - 1;
                else low = middle + 1;
            }
            return -1;
        }

        static int BinarySearchRec<T>(T[] arr, T key, int low, int high) where T : IComparable<T>
        {
            if (low > high) return -1;
            int middle = (low + high) / 2;
            if (key.CompareTo(arr[middle]) == 0) return middle;
            if (key.CompareTo(arr[middle]) < 0) high = middle -1;
            else low = middle + 1;

            return BinarySearchRec(arr, key, low, high);
        }

        record abc(int i, string s);
        class xyz : IEquatable<xyz>
        {
            int i;
            string s;

            public xyz(int i, string s)
            {
                this.i = i;
                this.s = s;
            }

            public bool Equals(xyz? other)
            {
                return other != null && this.i == other.i && this.s == other.s;
            }

            public override string ToString()
            {
                return $"i: {i}, s: {s}";
            }
        }
    }
}