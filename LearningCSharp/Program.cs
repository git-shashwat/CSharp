using System;

namespace LearningCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Class2 c = new Class2();
			c.MethodExtension(69);
			int t1 = 34;
			Console.WriteLine(t1.Factorial());

			string s1 = "tOp Of THe MorNinG";
			Console.WriteLine(s1.ToSentenceCase());
		}
	}
}
