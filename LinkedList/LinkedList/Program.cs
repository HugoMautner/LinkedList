using System;
using System.Collections;
using System.Collections.Generic;

public class MyLinkedList<T> : IEnumerable<Node<T>>
{
    private Node<T> first = null;

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
        while (current != null)
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
        while (current != null)
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
        Remove(Find(data));
        return true;
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
            return;
        }
        while (current != null)
        {
            if (current.Next.Equals(node))
            {
                current.Next = current.Next.Next;
                Count--;
                return;
            }
            current = current.Next;
        }
        throw new InvalidOperationException();
    }

    public Node<T> Get(int index)
    {
        if (index < 0)
            throw new ArgumentOutOfRangeException();

        if (Count == 0)
            return null;

        if (index >= Count)
            index = Count - 1;

        var current = first;
        for (int i = 0; i < index; i++)
            current = current.Next;
        return current;
    }
    public Node<T> this[int index]
    {
        get { return this.Get(index); }
    }

    public IEnumerator<Node<T>> GetEnumerator()
    {
        var current = first;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void PrintList(MyLinkedList<T> list)
    {
        foreach (var node in list)
        {
            Console.WriteLine(node.Data);
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