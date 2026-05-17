using System;

namespace MyBubbleSortProj;

public class MyMergeSort<T> where T : IComparable<T>
{
    public void Sort(T[] items)
    {
        if (items == null || items.Length < 2) return;
        MergeSort(items, 0, items.Length - 1);
    }

    private void MergeSort(T[] items, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(items, left, mid);
            MergeSort(items, mid + 1, right);

            Merge(items, left, mid, right);
        }
    }

    private void Merge(T[] items, int left, int mid, int right)
    {
        int length = right - left + 1;
        T[] temp = new T[length];

        int i = left;     
        int j = mid + 1;  
        int k = 0;  

        while (i <= mid && j <= right)
        {
            if (items[i].CompareTo(items[j]) <= 0)
            {
                temp[k] = items[i];
                i++;
            }
            else
            {
                temp[k] = items[j];
                j++;
            }
            k++;
        }


        while (i <= mid)
        {
            temp[k] = items[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            temp[k] = items[j];
            j++;
            k++;
        }

        for (k = 0; k < length; k++)
        {
            items[left + k] = temp[k];
        }
    }
}