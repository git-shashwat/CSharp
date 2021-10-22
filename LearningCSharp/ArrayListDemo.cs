using System;
using System.Collections;

public class ArrayListDemo
{
	static void Main()
    {
        ArrayList al = new ArrayList();

        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        al.Add(5);

        al.RemoveAt(2);

        Console.WriteLine(al.Count);
    }
}
