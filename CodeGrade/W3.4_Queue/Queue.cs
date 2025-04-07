namespace Solution;

public class Queue<T> : IQueue<T>
{
    private int front;
    private int back;
    private T[] data;
    private int _count = 0;

    public bool Empty => _count == 0;
    public bool Full => _count == data.Length;
    public int Count => _count;
    public int Size => data.Length;

    public Queue(int capacity = 5)
    {
        data = new T[capacity];
        front = 0;
        back = 0;
    }

    public void Enqueue(T element)
    {
        if (Full)
        {
            T?[] newData = new T[data.Length * 2];

            for (int i = 0; i < _count; i++)
            {
                newData[i] = data[(front + i) % data.Length];
            }

            data = newData;
            front = 0;
            back = _count;
        }

        data[back] = element;
        back = (back + 1) % data.Length;
        _count++;
    }

    public T? Dequeue()
    {
        if (Empty)
        {
            return default;
        }

        T? result = data[front];
        data[front] = default;
        front = (front + 1) % data.Length;
        _count--;

        return result;
    }

}