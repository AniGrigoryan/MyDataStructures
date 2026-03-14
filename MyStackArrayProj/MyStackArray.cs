using System;

namespace StackArray
{
    class MyStack<T>
    {
        private T[] elements;
        private int top;
        private int max;

        public MyStack(int size)
        {
            max = size;
            elements = new T[max];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow!");
                return;
            }
            elements[++top] = item;
        }
        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow!");
                return default(T);
            }
            return elements[top--];
        }

        public T Peek()
        {
            if (top == -1) return default(T);
            return elements[top];
        }

        public void Display()
        {
            if (top == -1) { Console.WriteLine("Stack is empty."); return; }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(i + ": " + elements[i]);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyStack<int> stack = new MyStack<int>(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Current Stack:");
            stack.Display();

            Console.WriteLine("Top element: " + stack.Peek());
            Console.WriteLine("Removed: " + stack.Pop());

            Console.WriteLine("\nStack after Pop:");
            stack.Display();

        }
    }
}