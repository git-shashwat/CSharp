using System;

public class TestClass
{
    string val;
    public static string operator -(TestClass a, TestClass b)
    {
        return a.val + b.val;
    }
	static void Main(string[] args)
    {
        TestClass t1 = new TestClass(), t2 = new TestClass();
        t1.val = "Hello";
        t2.val = "World";
        Console.WriteLine(t1 - t2);
    }
}
