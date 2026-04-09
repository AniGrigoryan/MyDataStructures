using MyLinkedListProj;
using System.Collections;

namespace MyPriortyQueueProj;

public class PriorityQueue<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private MyLinkedList<T> items = new MyLinkedList<T>();

    public void Enqueue(T item)
    {
        if (items.Count == 0)
        {
            items.AddLast(item);
        }
        else
        {
            var current = items.Head;

            while (current != null && current.Value.CompareTo(item) > 0)
            {
                current = current.Next;
            }
            if (current == null)
                {
                items.AddLast(item);
                }
            else
            {
                items.AddBefore(current,item);
            }
        }
    }

    public T Dequeue()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("The Queue is empty");
        T value = items.Head.Value;
        items.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("The Queue is empty");
        return items.Head.Value;
    }

    public int Count => items.Count;

    public void Clear()
    {
        items.Clear();
    }
     
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
