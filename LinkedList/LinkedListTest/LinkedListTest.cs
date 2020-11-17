using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;

[TestClass]
public class LinkedListTest
{
    //[TestMethod]
    //private void TestIndexingException()
    //{
    //    var list = new MyLinkedList<int>();
    //    int value = 0;

    //    //Assert
    //    Assert.AreEqual(0, list.Count);

    //    Assert.ThrowsException<IndexOutOfRangeException>(() => value = list[0]);


    //    var e = list.GetEnumerator();

    //    Assert.ThrowsException<InvalidOperationException>(() => e.Current);

    //}

    private MyLinkedList<int> ListSetUp()
    {
        MyLinkedList<int> list = new MyLinkedList<int>();

        list.AddFirst(1); list.AddFirst(5); list.AddFirst(7); 
        list.AddFirst(3); list.AddFirst(2); list.AddFirst(10);
        return list;
    }

    [TestMethod]
    public void TestAddFirst() //Also tests Contains()
    {
        //Assign + act
        var list = ListSetUp();

        //Assert
        Assert.AreEqual(6, list.Count);
        Assert.IsTrue(list.Contains(10));
        Assert.IsFalse(list.Contains(100));
        Assert.ThrowsException<IndexOutOfRangeException>(() => list[100] = 7);
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
        var list = ListSetUp();
        
        //Act
        list.Clear();

        //Assert
        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void TestFind()
    {
        //Assign
        var list = ListSetUp();
        int value = 5;

        //Act
        var node = list.Find(value);

        //Assert
        Assert.AreEqual(value, node.Data);
    }

    [TestMethod]
    public void TestRemove()
    {
        //Assign
        var list = ListSetUp();

        //Act
        list.Remove(1);
        list.Remove(7);

        //Assert
        Assert.IsFalse(list.Contains(1));
        Assert.IsFalse(list.Contains(7));
        Assert.AreEqual(4, list.Count);
    }
}