
namespace ToDo;

public class BinarySearch
{
    public static int binarySearch<T>(T[] a, T v) where T : IComparable
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

    public static int binarySearchRecursive<T>(T[] a, int low, int high, T v) where T : IComparable
    {
        Utils.ShowCallStack(); //DO NOT comment this line of code

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
            return binarySearchRecursive(a, mid + 1, high, v);
        }
        else
        {
            return binarySearchRecursive(a, low, mid - 1, v);
        }
    }

}
