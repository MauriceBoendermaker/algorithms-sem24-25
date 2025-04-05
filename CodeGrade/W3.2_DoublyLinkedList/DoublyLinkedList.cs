using System.Collections;

namespace Solution;

public class DoublyLinkedList<T> : IDoublyLinkedList<T> where T : IComparable<T>
{
    public DoubleNode<T>? First, Last;
    public DoublyLinkedList() => First = Last = null;
    public void Clear() => First = Last = null;

    //Search
    public DoubleNode<T>? Search(T value)
    {
        var current = First;
        while (current != null)
        {
            if (current.Value.CompareTo(value) == 0)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    #region "addNode=> first, last, sorted" 
    public void AddFirst(T value)
    {
        var newNode = new DoubleNode<T>(value, First, null);
        if (First != null)
        {
            First.Previous = newNode;
        }
        else
        {
            Last = newNode;
        }
        First = newNode;
    }

    public void AddLast(T value)
    {
        var newNode = new DoubleNode<T>(value, null, Last);
        if (Last != null)
        {
            Last.Next = newNode;
        }
        else
        {
            First = newNode;
        }
        Last = newNode;
    }

    public void AddSorted(T value)
    {
        if (First == null || First.Value.CompareTo(value) >= 0)
        {
            AddFirst(value);
            return;
        }

        var current = First;
        while (current.Next != null && current.Next.Value.CompareTo(value) < 0)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            AddLast(value);
            return;
        }

        var newNode = new DoubleNode<T>(value, current.Next, current);
        current.Next.Previous = newNode;
        current.Next = newNode;
    }
    #endregion

    public bool Remove(T value)
    {
        var node = Search(value);
        if (node == null)
        {
            return false;
        }

        Delete(node);
        return true;
    }

    public void Delete(DoubleNode<T> node)
    {
        if (node.Previous != null)
        {
            node.Previous.Next = node.Next;
        }
        else
        {
            First = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Previous = node.Previous;
        }
        else
        {
            Last = node.Previous;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        DoubleNode<T>? current = First;
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
