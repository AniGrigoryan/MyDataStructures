public class MyBubbleSort<T> where T : IComparable<T>
{
    public void Sort(T[] items)
    {

        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i - 1].CompareTo(items[i]) > 0)
                {
                    Swap(items, i - 1, i);
                    swapped = true;
                }
            }
        } while (swapped !=false);
    }


    private void Swap(T[] items, int index1, int index2)
    {
        T temp = items[index1];
        items[index1] = items[index2];
        items[index2] = temp;
    }
}