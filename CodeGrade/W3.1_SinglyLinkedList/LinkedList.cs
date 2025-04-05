using System.Collections;

namespace Solution;

public class SinglyLinkedList<T> : ILinkedList<T> where T : IComparable<T>
{
    public SingleNode<T>? Head;
    private SingleNode<T>? Tail;
    private int count;

    public SinglyLinkedList()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    public int Count => count;

    public void AddFirst(T value)
    {
        var newNode = new SingleNode<T>(value, Head);
        Head = newNode;
        if (Tail == null) Tail = Head;
        count++;
    }

    public void AddLast(T value)
    {
        var newNode = new SingleNode<T>(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode;
            Tail = newNode;
        }
        count++;
    }

    public bool Remove(T value)
    {
        if (Head == null) return false;

        if (Head.Value.CompareTo(value) == 0)
        {
            Head = Head.Next;
            if (Head == null) Tail = null;
            count--;
            return true;
        }

        SingleNode<T> current = Head;
        while (current.Next != null && current.Next.Value.CompareTo(value) != 0)
        {
            current = current.Next;
        }

        if (current.Next == null) return false;

        current.Next = current.Next.Next;
        if (current.Next == null) Tail = current;
        count--;
        return true;
    }

    public SingleNode<T>? Search(T value)
    {
        SingleNode<T>? current = Head;
        while (current != null)
        {
            if (current.Value.CompareTo(value) == 0)
                return current;
            current = current.Next;
        }
        return null;
    }

    public bool Contains(T value)
    {
        return Search(value) != null;
    }

    public void AddSorted(T value)
    {
        var newNode = new SingleNode<T>(value);
        if (Head == null || Head.Value.CompareTo(value) >= 0)
        {
            newNode.Next = Head;
            Head = newNode;
            if (Tail == null) Tail = newNode;
        }
        else
        {
            SingleNode<T> current = Head;
            while (current.Next != null && current.Next.Value.CompareTo(value) < 0)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            if (newNode.Next == null) Tail = newNode;
        }
        count++;
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        SingleNode<T>? current = Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
