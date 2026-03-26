using System.Collections;

namespace MyBinaryTreeProj;

public class MyBinaryTree<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private MyBinaryTreeNode<T> _head;
    private int _count;

    public int Count
    {
        get { return _count; }
    }

    public void Clear()
    {
        _head = null;
        _count = 0;
    }

    public bool Contains(T value)
    {
        MyBinaryTreeNode<T> current = _head;

        while (current != null)
        {
            int result = value.CompareTo(current.Value);

            if (result == 0)
                return true;

            if (result < 0)
                current = current.Left;
            else
                current = current.Right;
        }

        return false;
    }

    public IEnumerable<T> PostOrderTraversal()
    {
        List<T> result = new List<T>();
        PostOrder(result, _head);
        return result;
    }

    private void PostOrder(List<T> list, MyBinaryTreeNode<T> node)
    {
        if (node == null)
            return;

        PostOrder(list, node.Left);
        PostOrder(list, node.Right);
        list.Add(node.Value);
    }

 #region Add
    public void Add(T value)
    {
        if (_head == null)
        {
            _head = new MyBinaryTreeNode<T>(value);
        }
        else
        { 
            MyBinaryTreeNode<T> current = _head;

            while (true)
            {
                int result = value.CompareTo(current.Value);
                if (result < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = new MyBinaryTreeNode<T>(value);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new MyBinaryTreeNode<T>(value);
                        break;
                    }
                    current = current.Right;
                }
            }
        }
        _count++;
    }
    #endregion Add

 #region Remove
    public bool Remove(T value)
    {
        MyBinaryTreeNode<T> current = _head;
        MyBinaryTreeNode<T> parent = null;
        while (current != null)
        {
            int result = value.CompareTo(current.Value);
            if (result == 0)
                break; 

            parent = current;

            if (result < 0)
                current = current.Left;
            else
                current = current.Right;
        }

        if (current == null)
            return false;

        if (current.Left != null && current.Right != null)
        {
            MyBinaryTreeNode<T> successor = current.Right;
            MyBinaryTreeNode<T> successorParent = current;

            while (successor.Left != null)
            {
                successorParent = successor;
                successor = successor.Left;
            }

            current.Value = successor.Value;

            current = successor;
            parent = successorParent;
        }

        MyBinaryTreeNode<T> child;
        if (current.Left != null)
            child = current.Left;
        else
            child = current.Right;

        if (parent == null)
        {

            _head = child;
        }
        else if (parent.Left == current)
        {
            parent.Left = child;
        }
        else
        {
            parent.Right = child;
        }

        _count--;
        return true;
    }
    #endregion Remove

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return PostOrderTraversal().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return PostOrderTraversal().GetEnumerator();
    }

    public IEnumerable<object> PostOrder()
    {
        throw new NotImplementedException();
    }
}