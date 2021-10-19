using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class2 : Class1
{
    public Class2()
    {
        Console.WriteLine("Class 2 constructor called.");
    }

    public new void MethodOne()
    {
        Console.WriteLine("MethodOne from child class.");
    }

    public void MethodTwo()
    {
        Console.WriteLine("Mehod Two called");
    }
}
