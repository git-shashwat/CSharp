using System;
using System.Threading;

public class MultiThreading
{
	static void Method1(object max)
    {
        int num = Convert.ToInt32(max);
        for (int i = 1; i <= num; ++i)
        {
            Console.WriteLine("Method 1: " + i);
        }
    }

    static void Method2()
    {
        for (int i = 1; i <= 100; ++i)
        {
            Console.WriteLine("Method 2: " + i);
            if (i == 50)
            {
                Console.WriteLine("Thread 2 going to sleep");
                Thread.Sleep(10000);
                Console.Write("Thread 2 woke up and chose violence");
            }
        }
    }

    static void Method3()
    {
        for (int i = 1; i <= 100; ++i)
        {
            Console.WriteLine("Method 3: " + i);
        }
    }

    static void Main()
    {
        // ThreadStart ts = new ThreadStart(Method1);
        // ThreadStart ts = () => Method1();
        ParameterizedThreadStart pts = new ParameterizedThreadStart(Method1);
        Thread t = new Thread(pts);

        t.Start(75);
    }
}
