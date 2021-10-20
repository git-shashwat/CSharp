using System;

public delegate int AddDelegate(int a, int b);
public delegate void SayDelegate(string str);

public class DelegatesDemo
{
	public int AddNums (int x, int y)
    {
		return x + y;
    }

	public static void SayHello(string name)
    {
		Console.WriteLine("Hello " + name);
    }

	public static void SayBye(string name)
    {
		Console.WriteLine("Bye " + name);
    }

	static void Main(string[] args)
	{
		DelegatesDemo demo = new DelegatesDemo();
		int ans = demo.AddNums(62, 7);
		Console.WriteLine(ans);
		SayHello("Shashwat");

		// delegates way
		AddDelegate ad = new AddDelegate(demo.AddNums);
		SayDelegate sd = SayHello;
		sd += SayBye;

		ans = ad.Invoke(23, 45);
		Console.WriteLine(ans);
		sd.Invoke("John");

		sd = (name) =>
		{
			Console.WriteLine("Good morning " + name);
		};

		sd.Invoke("Bro");
	}
}
