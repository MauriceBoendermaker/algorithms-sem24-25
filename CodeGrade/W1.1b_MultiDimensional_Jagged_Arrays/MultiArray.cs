using System.Numerics;

namespace ToDo;

public class MultiArray : IMultiArray
{
    public static T[]? RowSum<T>(T[,] arr2D) where T : INumber<T>
    {
        T[] sum = new T[arr2D.GetLength(0)];

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            sum[i] = T.Zero;

            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                sum[i] += arr2D[i, j];
            }
        }
        return sum;
    }

    public static T[]? ColSum<T>(T[,] arr2D) where T : INumber<T>
    {
        T[] sum = new T[arr2D.GetLength(1)];

        for (int i = 0; i < arr2D.GetLength(1); i++)
        {
            sum[i] = T.Zero;

            for (int j = 0; j < arr2D.GetLength(0); j++)
            {
                sum[i] += arr2D[i, j];
            }
        }
        return sum;
    }

    public static Tuple<int, T>? MaxRowIndexSum<T>(T[][] arrJagged) where T : INumber<T>
    {
        T maxSum = T.Zero;
        int maxIndex = -1;

        for (int i = 0; i < arrJagged.Length; i++)
        {
            if (arrJagged[i] == null || arrJagged[i].Length == 0)
            {
                continue;
            }

            T sum = T.Zero;

            foreach (T elem in arrJagged[i])
            {
                sum += elem;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxIndex = i;
            }
        }
        return maxIndex != -1 ? Tuple.Create(maxIndex, maxSum) : null;
    }

    public static T?[] MaxCol<T>(T[][] arrJagged) where T : INumber<T>
    {
        //ToDo
        throw new NotImplementedException();
    }

    public static T[][]? Split<T>(Tuple<T, T, T>[] input)
    {
        if (input == null || input.Length == 0)
        {
            return null;
        }

        T[][] jaggedArray = new T[3][];
        jaggedArray[0] = new T[input.Length];
        jaggedArray[1] = new T[input.Length];
        jaggedArray[2] = new T[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            jaggedArray[0][i] = input[i].Item1;
            jaggedArray[1][i] = input[i].Item2;
            jaggedArray[2][i] = input[i].Item3;
        }
        return jaggedArray;
    }

    public static T[,]? Zip<T>(T[] a, T[] b)
    {
        //ToDo
        throw new NotImplementedException();
    }
}