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
        throw new NotImplementedException();
    }

    #region "addNode=> first, last, sorted" 
    public void AddFirst(T value)
    {
        throw new NotImplementedException();
    }

    public void AddLast(T value)
    {
        throw new NotImplementedException();
    }

    public void AddSorted(T value)
    {
        throw new NotImplementedException();
    }
    #endregion

    public bool Remove(T value)
    {
        throw new NotImplementedException();
    }

    public void Delete(DoubleNode<T> node)
    {
        // check Prev
        // check Next
        // check First
        // check Last
        throw new NotImplementedException();

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
