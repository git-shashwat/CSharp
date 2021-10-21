using System;

public class GenericDelegates
{
    static void Main(string[] args)
    {
        Func<int, float, double, double> foo = (a, b, c) => a + b + c;
        Action<string> bar = (name) => Console.WriteLine(name);
        Predicate<string> zee = (str) => str.Length > 5;

        double result = foo.Invoke(2, 3.42f, 83.423);
        Console.WriteLine(result);

        bar.Invoke("Shashwat");

        bool ans = zee.Invoke("Shashwat");
        Console.WriteLine(ans);
    }
}
