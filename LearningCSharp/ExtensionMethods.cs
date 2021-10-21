using System;

static class ExtensionsMethod
{
	public static void MethodExtension(this Class2 P, int x)
    {
        Console.WriteLine("This is an extension method " + x);
    }

    public static long Factorial(this Int32 x)
    {
        if (x == 1)
            return 1;
        if (x == 2)
            return 2;
        return x * Factorial(x - 1);
    }

    public static string ToSentenceCase(this string oldStr)
    {
        if (oldStr.Trim().Length > 0)
        {
            string newStr = null;
            oldStr = oldStr.ToLower();
            string[] sArr = oldStr.Split(' ');
            foreach (var str in sArr)
            {
                char[] cArr = str.ToCharArray();
                cArr[0] = Char.ToUpper(cArr[0]);
                if (newStr == null)
                    newStr = new string(cArr);
                else
                    newStr += " " + new string(cArr);
            }
            return newStr;
        }
        return oldStr;
    }
}
