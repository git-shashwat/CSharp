using System;
using System.Threading;

public class MultiThreading
{
    public static long count1, count2;
	public void Method1()
    {
        lock (this)
        {
            Console.Write("CSharp is kinda cool");
            Thread.Sleep(5000);
            Console.WriteLine(" programming language.");
        }
    }

    static void Method2()
    {
        for (int i = 1; i <= 100; ++i)
        {
            Console.WriteLine("Method 2: " + i);
        }
    }

    static void Method3()
    {
        for (int i = 1; i <= 100; ++i)
        {
            Console.WriteLine("Method 3: " + i);
        }
    }

    static void Increment1()
    {
        while (true)
            count1++;
    }

    static void Increment2()
    {
        while (true)
            count2++;
    }

    static void Main()
    {
        //MultiThreading obj = new MultiThreading();
        //Thread t1 = new Thread(obj.Method1);
        //Thread t2 = new Thread(obj.Method1);
        //Thread t3 = new Thread(obj.Method1);

        //t1.Start();
        //t2.Start();
        //t3.Start();

        //t1.Join();
        //t2.Join();
        //t3.Join();

        Thread t1 = new Thread(Increment1);
        Thread t2 = new Thread(Increment2);

        t1.Start();
        t2.Start();

        Console.WriteLine("Main thread going to sleep");
        Thread.Sleep(5000);
        Console.WriteLine("Main thread woke up.");

        t1.Abort();
        t2.Abort();

        t1.Join();
        t2.Join();

        Console.WriteLine("Count1 = " + count1);
        Console.WriteLine("Count2 = " + count2);

        Console.WriteLine("Main thread exiting");
    }
}
