using System;
using System.Diagnostics;
using System.Text;

public class StringVsStringBuilder
{
    static void Main(string[] args)
    {
        string s = "";
        Stopwatch t1 = new Stopwatch();

        t1.Start();
        for (int i = 0; i < 100000; i++)
        {
            s += i;
        }
        t1.Stop();

        StringBuilder sb = new StringBuilder(100000);
        Stopwatch t2 = new Stopwatch();

        t2.Start();
        for (int i = 0; i < 100000; i++)
        {
            sb.Append(i);
        }
        t2.Stop();

        Console.WriteLine("Time taken by string: " + t1.ElapsedMilliseconds);
        Console.WriteLine("Time taken by StringBuilder: " + t2.ElapsedMilliseconds);
    }
}
