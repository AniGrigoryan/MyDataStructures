using MyBinaryTreeProj;
using MyLinkedListProj;
using MyQueueProj;
using MyStackProj;
using MyBubbleSortProj;
using System.Collections;

namespace Testing_DataStructures;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("---TESTING--");

        Console.WriteLine("---Bubble Sort--");
        MyBubleSort();
        Console.WriteLine("---Insertion Sort--");
        MyInsertionSort();
        Console.WriteLine("---Selection Sort--");
        MySelectionSort();
        Console.WriteLine("---Quick Sort--");
        MyQuickSort();
        Console.WriteLine("---Merge Sort--");
        MyMergeSort();

        #region LinkedList
        var linkedList = new MyLinkedList<string>();

        linkedList.AddFirst("1");
        linkedList.AddFirst("3");
        linkedList.AddFirst("5");
        linkedList.AddFirst("7");
        linkedList.AddFirst("9");

        foreach (var item in linkedList)
        {
            Console.WriteLine($"Current Item: {item}");
        }

        Console.WriteLine();
        linkedList.RemoveFirst();



        foreach (var item in linkedList)
        {
            Console.WriteLine($"Current Item: {item}");
        }

        #endregion LinkedList

        #region Stack
        Console.WriteLine("---Stack---");
        var stack = new MyStack<string>();
        stack.Push("F");
        stack.Push("N");
        stack.Push("6");
        stack.Push("4");
        foreach (var item in stack)
        {
            Console.WriteLine($"Current Item: {item}");
        }
        Console.WriteLine();
        Console.WriteLine("Top:" + stack.Peek());
        stack.Pop();
        Console.WriteLine("After Pop Top:" + stack.Peek());

        #endregion Stack

        #region Queue
        Console.WriteLine("---Queue---");

        var queue = new MyQueue<string>();

        queue.Enqueue("X");
        queue.Enqueue("Y");
        queue.Enqueue("Z");
        queue.Enqueue("W");

        Console.WriteLine("Queue Items:");

        foreach (var item in queue)
        {
            Console.WriteLine($"Current Item: {item}");
        }

        Console.WriteLine();

        Console.WriteLine("Front of Queue: " + queue.Peek());

        queue.Dequeue();

        Console.WriteLine("After Dequeue Front: " + queue.Peek());

        queue.Dequeue();

        Console.WriteLine("After Dequeue Front: " + queue.Peek());

        #endregion Queue

        #region BinaryTree

        Console.WriteLine("---Binary Tree---");

        var tree = new MyBinaryTree<int>();

        // Add elements
        tree.Add(4);
        tree.Add(2);
        tree.Add(6);
        tree.Add(1);
        tree.Add(3);
        tree.Add(5);
        tree.Add(7);

        // PostOrder
        Console.WriteLine("PostOrder:");
        foreach (var item in tree.PostOrder())
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Remove leaf
        Console.WriteLine("Remove (2):");
        tree.Remove(2);
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Remove node with one child
        Console.WriteLine("Remove node with one child (3):");
        tree.Remove(3);
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Remove node with two children
        Console.WriteLine("Remove node with two children (5):");
        tree.Remove(5);
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        #endregion BinaryTree
    }
    #region Bubble Sort
    static void MyBubleSort()
    {
        int[] numbers = { 52, 10, 85, 24, 61, 3, 11 };
        MyBubbleSort<int> intSorter = new MyBubbleSort<int>();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        intSorter.Sort(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
    #endregion Bubble Sort

    #region Selection Sort
    static void MySelectionSort()
    {
        int[] numbers = { 52, 10, 85, 24, 61, 3, 11 };
        MySelectionSort<int> intSorter = new MySelectionSort<int>();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        intSorter.Sort(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
    #endregion Selection Sort

    #region Insertion Sort
    static void MyInsertionSort()
    {
        int[] numbers = { 52, 10, 85, 24, 61, 3, 11 };
        MyInsertionSort<int> intSorter = new MyInsertionSort<int>();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        intSorter.Sort(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
    #endregion Insertion Sort

    #region Quick Sort
    static void MyQuickSort()
    {
        int[] numbers = { 52, 10, 85, 24, 61, 3, 11 };
        MyQuickSort<int> intSorter = new MyQuickSort<int>();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        intSorter.Sort(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
    #endregion Quick Sort

    #region Merge Sort
    static void MyMergeSort()
    {
        int[] numbers = { 52, 10, 85, 24, 61, 3, 11 };
        MyMergeSort<int> intSorter = new MyMergeSort<int>();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        intSorter.Sort(numbers);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
    #endregion Merge Sort

}