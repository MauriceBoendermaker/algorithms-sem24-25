using System.Numerics;

namespace ToDo;

public class MultiArray : IMultiArray
{
    public static T[]? RowSum<T>(T[,] arr2D) where T : INumber<T>
    {
        //ToDo
        throw new NotImplementedException();
    }
    public static T[]? ColSum<T>(T[,] arr2D) where T : INumber<T>
    {
        //ToDo
        throw new NotImplementedException();
    }

    public static Tuple<int, T>? MaxRowIndexSum<T>(T[][] arrJagged) where T : INumber<T>
    {
        //ToDo
        throw new NotImplementedException();
    }

    public static T?[] MaxCol<T>(T[][] arrJagged) where T : INumber<T>
    {
        //ToDo
        throw new NotImplementedException();
    }

    public static T[][]? Split<T>(Tuple<T, T, T>[] input)
    {
        //ToDo
        throw new NotImplementedException();
    }

    public static T[,]? Zip<T>(T[] a, T[] b)
    {
        //ToDo
        throw new NotImplementedException();
    }
}