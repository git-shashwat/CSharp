using System;

public struct StructDemo
{
	int i;
	public StructDemo(int i)
    {
        this.i = i;
    }

    public void Display()
    {
        Console.WriteLine(i);
    }

    static void Main(string[] args)
    {
        StructDemo s1 = new StructDemo();
        s1.Display();

        StructDemo s2 = new StructDemo(20);
        s2.Display();

        StructDemo s3;
        s3.i = 30;
        s3.Display();

        // structures don't support inheritance
        // structures can implement interfaces the same way as classes
    }
}
