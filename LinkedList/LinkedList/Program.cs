using System;
using System.Collections.Generic;
using System.Transactions;

public class MyLinkedList<T>
{
    //To delete specific node
    //current.Next = current.Next.Next
    //if (current.Next == null) { throw exeption or smth }

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
            AddFirst(data);

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