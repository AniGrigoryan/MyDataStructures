using MyLinkedListProj;
using MyQueueProj;
using MyStackProj;
using MyBinaryTreeProj;

namespace Testing_DataStructures;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("---TESTING--");


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
        tree.Add(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);

        Console.WriteLine("Tree contains 5: " + tree.Contains(5)); 
        Console.WriteLine("Tree contains 20: " + tree.Contains(20)); 

        Console.WriteLine("Post-Order Traversal:");
        foreach (var value in tree) 
        {
            Console.Write(value + " ");
        }
        
        Console.WriteLine("\n");

        Console.WriteLine("Removing node 20 (leaf)...");
        tree.Remove(20);
        Console.WriteLine("Contains 20: " + tree.Contains(20)); 

        Console.WriteLine("Removing node 30 (node with one child)...");
        tree.Remove(30);

        Console.WriteLine("Removing node 50 (root with two children)...");
        tree.Remove(50);

        Console.WriteLine($"Final Count: {tree.Count}"); 
        Console.WriteLine("Testing Binary Tree Finished!");
        #endregion

        #region HashTable

        #endregion HashTable

    }
}