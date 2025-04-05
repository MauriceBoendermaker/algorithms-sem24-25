namespace Solution;

public class Stack<T> : IStack<T>
{
    private T[] items;
    private int top;

    public bool Empty => top == 0;

    public bool Full => top == items.Length;

    public int Count => top;

    public int Size => items.Length;

    public Stack(int size = 4)
    {
        items = new T[size];
        top = 0;
    }

    public T? Peek()
    {
        if (Empty) return default;
        return items[top - 1];
    }

    public T? Pop()
    {
        if (Empty) return default;
        top--;
        return items[top];
    }

    public void Push(T Item)
    {
        if (Full)
        {
            var newItems = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
                newItems[i] = items[i];
            items = newItems;
        }

        items[top] = Item;
        top++;
    }
}
