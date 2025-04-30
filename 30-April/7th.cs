using System;

class Program
{
    static int Sub(int a, int b)
    {
        return a - b;
    }

    static double Sub(double a, double b)
    {
        return a - b;
    }

    static int Mul(int a, int b)
    {
        return a * b;
    }

    static double Mul(double a, double b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine("Int Sub: " + Sub(6, 3));        // Output: 3
        Console.WriteLine("Double Sub: " + Sub(6.8, 2.5));  // Output: 4.3

        Console.WriteLine("Int Mul: " + Mul(3, 4));         // Output: 12
        Console.WriteLine("Double Mul: " + Mul(2.5, 4.3));  // Output: 10.75
    }
}
