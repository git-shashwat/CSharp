using System;

public class Matrix: Object
{
    int a, b, c, d;
    public Matrix(int a, int b, int c, int d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix(0, 0, 0, 0);
        result.a = m1.a + m2.a;
        result.b = m1.b + m2.b;
        result.c = m1.c + m2.c;
        result.d = m1.d + m2.d;

        return result;
    }

    public override string ToString()
    {
        return a + " " + b + "\n" + c + " " + d + "\n";
    }

    static void Main(string[] args)
    {
        Matrix m1 = new Matrix(5, 10, 15, 20), m2 = new Matrix(10, 8, 6, 4);
        Matrix m3 = m1 + m2;

        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(m3);
    }
}
