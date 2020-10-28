using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;

[TestClass]
public class LinkedListTest
{
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
        Assert.AreEqual(true, list.Contains(5));

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
        Assert.AreEqual(true, list.Contains(34));

    }

    [TestMethod]
    public void TestClear()
    {

    }

    private void ListSetUp()
    {
        
    }
}