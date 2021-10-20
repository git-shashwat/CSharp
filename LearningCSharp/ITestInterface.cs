using System;

interface ITestInterface3
{
    int Mul(int a, int b);
}

interface ITestInterface2
{
    int Sub(int a, int b);
    void Show();
}

interface ITestInterface1 : ITestInterface2, ITestInterface3
{
    int Add(int a, int b); // default scope is public // by default these methods are abstract
    void Show();
}

public class Class5 : ITestInterface1
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    static void Main (string[] args)
    {
        Class5 c = new Class5();
        ITestInterface1 i1 = c;
        i1.Show();

        Console.WriteLine(c.Add(2, 5));
        Console.WriteLine(c.Sub(72, 3));
        Console.WriteLine(c.Mul(3, 23));
    }

    void ITestInterface1.Show()
    {
        Console.WriteLine("Iterface 1 method implented in class");
    }

    void ITestInterface2.Show()
    {
        throw new NotImplementedException();
    }
}