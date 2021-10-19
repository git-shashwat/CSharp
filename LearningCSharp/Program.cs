using System;

namespace LearningCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Class2 c = new Class2();
			Class1 p = new Class1();
			p.MethodOne();
			c.MethodOne();
			Console.WriteLine(c.ToString());
			// every class that we define or otherwise has a default parent class as Object class of System namespace
		}
	}
}
