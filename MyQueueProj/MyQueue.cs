using MyLinkedListProj;
using System.Collections;
using System.Collections.Generic; // Սա պարտադիր ավելացրու

namespace MyQueueProj;

public class MyQueue<T> : IEnumerable<T>
{
    private MyLinkedList<T> items = new MyLinkedList<T>();

    public void Enqueue(T item)
    {
        items.AddLast(item);
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

    // 1. Generic Enumerator
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    // 2. Non-generic Enumerator (Սա է փակում CS0535 սխալը)
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}