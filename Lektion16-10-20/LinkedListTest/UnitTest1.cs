using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAddition()
    {
        //Assign - tilldela resurser som behövs för att kunna testa
        Program p = new Program();
        int x = 10;
        int y = 5;
        int expected = x + y;

        //Act - utföra det som ska testas
        int sum = p.Sum(x, y);

        //Assert - kolla om resultat från "act" är expected
        Assert.AreEqual(expected, sum);
    }

    [TestMethod]

    public void TestMultiplication()
    {
        //Assign - tilldela resurser som behövs för att kunna testa
        Program p = new Program();
        int x = 10;
        int y = 5;
        int expectedProd = x * y;

        //Act - utföra det som ska testas
        int prodRes = p.Multiplication(x, y);

        //Assert - kolla om resultat från "act" är expected
        Assert.AreEqual(expectedProd, prodRes);
    }
}