using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

[TestClass]
public class LinkedListTest
{
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
        Assert.IsNull(list[0]);
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

        var f = list.AddFirst(4);
        var l = list.AddLast(20);
        list.Remove(f);
        list.Remove(l);

        //Assert
        Assert.IsFalse(list.Contains(1));
        Assert.IsFalse(list.Contains(7));

        Assert.IsFalse(list.Contains(4));
        Assert.IsFalse(list.Contains(20));
        Assert.AreEqual(4, list.Count);
    }

    [TestMethod]
    public void TestIndexing()
    {
        //Assign
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.AddFirst(1);
        var node = list.AddLast(2);

        //Act
        var testCurrent = list.Get(2);
        list.Clear();
        var testNull = list.Get(1);

        //Assert
        Assert.AreEqual(testCurrent, node);
        Assert.IsNull(testNull);
    }

    [TestMethod]
    public void TestGetEnumerator()
    {
        //Assign
        var list = ListSetUp();

        //Act
        var i = list.GetEnumerator();

        //Assert
        i.MoveNext();
        Assert.AreEqual(i.Current.Data, 10);
        i.MoveNext();
        Assert.AreEqual(i.Current.Data, 2);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestRemoveArgumentNullException()
    {
        //Assign
        var list = ListSetUp();

        //Act
        list.Remove(null);

        //Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestGetArgumentOutOfRangeException()
    {
        //Assign
        var list = ListSetUp();

        //Act
        list.Get(-5);

        //Assert
    }
}