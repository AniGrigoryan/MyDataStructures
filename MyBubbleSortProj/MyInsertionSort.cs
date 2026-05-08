using System;
using System.Collections.Generic;
using System.Text;

namespace MyBubbleSortProj;

internal class MyInsertionSort<T> where T : IComparable<T>
{
    public void Sort(T[] items)
    {
        if (items == null || items.Length < 2) return;

        for (int i = 1; i < items.Length; i++)
        {
            T key = items[i]; 
            int j = i - 1;

            while (j >= 0 && items[j].CompareTo(key) > 0)
            {
                items[j + 1] = items[j]; 
                j = j - 1;
            }

            items[j + 1] = key;
        }
    }
}
