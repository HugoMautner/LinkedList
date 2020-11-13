using System;
using System.Collections.Generic;
using System.Transactions;

public class MyLinkedList<T>
{
    private Node<T> first = null;

    public T this [int index]
    {
        get
        {
            return GetAt(index).Data;
        }
        set
        {
            GetAt(index).Data = value;
        }
    }

    private Node<T> GetAt(int index)
    {
        if (index >= Count)
            throw new IndexOutOfRangeException();

        var current = first;
        for (int i = 0; i < index; i++)
            current = current.Next;
        return current;
    }

    public int Count
    {
        get;
        private set;
    } = 0;

    public Node<T> AddFirst(T data)
    {
        var node = new Node<T>(data);
        node.Next = first;
        first = node;
        Count++;
        return node;
    }

    public Node<T> AddLast(T data)
    {
        if (Count == 0)
            return AddFirst(data);

        var node = new Node<T>(data);

        var current = first;
        while(current != null)
        {
            if (current.Next == null)
                break;
            current = current.Next;
        }
        current.Next = node;
        Count++;
        return node;
    }

    public void Clear()
    {
        first = null;
        Count = 0;
        return;
    }

    public bool Contains(T data)
    {
        var current = first;
        while(current != null)
        {
            if (current.Data.Equals(data))
                return true;

            current = current.Next;
        }
        return false;
    }

    public Node<T> Find(T data)
    {
        var current = first;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return current;

            current = current.Next;
        }
        return null;
    }

    public bool Remove(T data)
    {
        var current = first;

        if (current.Data.Equals(data))
        {
            first = first.Next;
            Count--;
            return true;
        }
        while (current != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                Count--;
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(Node<T> node)
    {
        var current = first;

        if (node == null)
            throw new ArgumentNullException();
        else if (current == node)
        {
            first = first.Next;
            Count--;
        }
        while (current != null)
        {
            if (current.Next.Equals(node))
            {
                current.Next = current.Next.Next;
                Count--;
            }
            current = current.Next;
        }
        throw new InvalidOperationException();
    }

    public class Enumerator
    {
        private MyLinkedList<T> list;
        private int position = -1;

        public Enumerator(MyLinkedList<T> list)
        {
            this.list = list;
        }

        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            position++;
            return position < list.Count;
        }

        public T Current 
        {
            get
            {
                if (position == -1)
                    throw new InvalidOperationException();
                return list[position];
            }
        }
    }
}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node(T data)
    { 
        Data = data;
    }
}

class Program
{
    static void Main()
    {

    }
}