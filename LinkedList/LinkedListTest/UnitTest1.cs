using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
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

    }
}