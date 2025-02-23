
namespace ToDo;

public class Search<T> : ISearch<T> where T : IComparable<T>
{
    public static int SequentialSearch(T[] a, T v)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Equals(v))
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(T[] a, T v)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (a[mid].Equals(v))
            {
                return mid;
            }
            else if (a[mid].CompareTo(v) < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    public static int BinarySearchRecursive(T[] a, T v, int low, int high)
    {
        Utils.ShowCallStack();

        if (low > high)
        {
            return -1;
        }

        int mid = (low + high) / 2;

        if (a[mid].Equals(v))
        {
            return mid;
        }
        else if (a[mid].CompareTo(v) < 0)
        {
            return BinarySearchRecursive(a, v, mid + 1, high);
        }
        else
        {
            return BinarySearchRecursive(a, v, low, mid - 1);
        }
    }

}
