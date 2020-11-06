using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;

[TestClass]
public class LinkedListTest
{
    private void ListSetUp()
    {

    }

    [TestMethod]
    public void TestAddFirst()
    {
        //Assign
        MyLinkedList<int> list = new MyLinkedList<int>();
        int value = 5;

        //Act
        var node = list.AddFirst(value);
        list.AddFirst(1);
        list.AddFirst(5);
        list.AddFirst(7);

        //Assert
        Assert.AreEqual(value, node.Data);
        Assert.AreEqual(4, list.Count);

        Assert.ThrowsException<IndexOutOfRangeException>(() => list[100] = 7);  //Anonym metod
    }

    [TestMethod]
    public void TestAddLast()
    {
        //Assign
        MyLinkedList<int> list = new MyLinkedList<int>();
        int value = 5;

        //Act
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(90);
        list.AddLast(34);
        var node = list.AddLast(value);

        //Assert
        Assert.AreEqual(value, node.Data);
        Assert.AreEqual(5, list.Count);
    }

    [TestMethod]
    public void TestClear()
    {
        //Assign
        MyLinkedList<int> list = new MyLinkedList<int>();

        //Act
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(90);
        list.AddLast(34);

        Console.WriteLine("Number of nodes: " + list.Count);

        list.Clear();

        //Assert
        Console.WriteLine("Number of nodes now: " + list.Count);
    }

    [TestMethod]
    public void TestContains()
    {
        //Assign
        MyLinkedList<int> list = new MyLinkedList<int>();

        //Act
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(5);
        list.AddLast(34);

        //Assert
        Assert.AreEqual(true, list.Contains(5));
    }

    [TestMethod]
    public void TestFind()
    {
        //Assign

        //Act

        //Assert
    }

    [TestMethod]
    public void TestRemove()
    {
        //Assign

        //Act

        //Assert
    }
}