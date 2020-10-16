using System;
using System.Collections.Generic;


public class MyLinkedList<T>
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