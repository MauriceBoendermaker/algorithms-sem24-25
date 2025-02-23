using System.Numerics;

namespace ToDo;
public class NumArray1D<T> : Array1D<T>, INumArray1D<T> where T : IComparable<T>, INumber<T>
{
    public NumArray1D(int size = 10) : base(size) { }
    public NumArray1D(T[] data) : base(data) { }

    public T? Aggregate(Func<T, T, T> fx)
    {
        if (_index == 0)
        {
            return default(T);
        }

        T result = _data[0];
        for (int i = 1; i < _index - 1; i++)
        {
            result = fx(result, _data[i]);
        }
        return result;
    }

    public T? Max()
    {
        if (_index == 0)
        {
            return default(T);
        }

        T maxValue = _data[0];
        for (int i = 1; i < _index - 1; i++)
        {
            if (_data[i] > maxValue)
            {
                maxValue = _data[i];
            }
        }
        return maxValue;
    }

    public T? Min()
    {
        if (_index == 0)
        {
            return default(T);
        }

        T minValue = _data[0];
        for (int i = 1; i < _index - 1; i++)
        {
            if (_data[i] < minValue)
            {
                minValue = _data[i];
            }
        }
        return minValue;
    }

    public T? Product(bool IgnoreZeros = true)
    {
        if (_index == 0)
        {
            return T.One;
        }

        T product = T.One;
        for (int i = 0; i < _index; i++)
        {
            if (IgnoreZeros && _data[i] == T.Zero)
            {
                continue;
            }

            product *= _data[i];
        }
        return product;
    }

    public T? Sum()
    {
        var result = Aggregate((a, b) => a + b);
        return result;
    }
}