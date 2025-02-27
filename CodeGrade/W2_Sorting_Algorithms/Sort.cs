namespace ToDo;
public class Sort<T> : ISort<T> where T : IComparable<T>
{
    public static void BubbleSort(T[] data)
    {
        T temp;

        for (int i = 0; i < data.Length - 1; i++)
        {
            for (int j = 0; j < data.Length - 1 - i; j++)
            {
                if (data[j].CompareTo(data[j + 1]) > 0)
                {
                    temp = data[j + 1];
                    data[j + 1] = data[j];
                    data[j] = temp;
                }
            }
        }
    }

    public static void InsertionSort(T[] data)
    {
        for (int j = 1; j < data.Length; j++)
        {
            T key = data[j];

            int i = j - 1;

            while (i >= 0 && data[i].CompareTo(key) > 0)
            {
                data[i + 1] = data[i];
                i--;
            }
            data[i + 1] = key;
        }
    }

    public static void MergeSort(T[] array, int low, int high)
    {
        if (low < high)
        {
            int middle = low + (high - low) / 2;

            MergeSort(array, low, middle);
            MergeSort(array, middle + 1, high);
            Merge(array, low, middle, high);
        }
    }

    public static void Merge(T[] array, int low, int middle, int high)
    {
        int i, j, k;
        int leftArrayLength = middle - low + 1;
        int rightArrayLength = high - middle;

        T[] left = new T[leftArrayLength];
        T[] right = new T[rightArrayLength];

        for (i = 0; i < leftArrayLength; i++)
        {
            left[i] = array[low + i];
        }

        for (i = 0; i < rightArrayLength; i++)
        {
            right[i] = array[middle + 1 + i];
        }

        i = 0;
        j = 0;
        k = low;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (left[i].CompareTo(right[j]) <= 0)
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        if (i == leftArrayLength)
        {
            for (int ii = j; ii < rightArrayLength; ii++)
            {
                array[k++] = right[ii];
            }
        }

        if (j == rightArrayLength)
        {
            for (int ii = i; ii < leftArrayLength; ii++)
            {
                array[k++] = left[ii];
            }
        }
    }
}