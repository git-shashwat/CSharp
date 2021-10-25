using System;
using System.Linq;

public class LinqDemo
{
    static void Main()
    {

        int[] arr = { 34, 1, 54, 49, 73, 23 };

        var brr = from i in arr where i > 40 orderby i descending select i;

        foreach (int i in brr)
            Console.Write(i + " ");
    }
}
