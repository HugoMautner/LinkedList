using System;
using System.Collections.Generic;

public class Program
{

    static void Main()
    {
        MyClass<int> mc = new MyClass<int>();
        mc.SetData(10);

        MyClass<string> mc2 = new MyClass<string>();
        mc2.SetData("Namnet är Bofi");
    }

    public int Sum(int x, int y)
    {
        return x + y;
    }

    public int Multiplication(int x, int y)
    {
        return x * y;
    }
}

public class MyClass<T>     //man kan även ha fler datatyper T1, T2, T3 osv. Funkar som tupel-klassen
{
    public T data;
    
    public T GetData()
    {
        return data;
    }

    public void SetData(T data)
    {
        this.data = data;
    }
}