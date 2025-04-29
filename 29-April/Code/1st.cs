using System;

public class HelloWorld
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        if (b != 0)
            return (double)a / b;
        else
            return double.NaN;
    }

    public static void Main()
    {
        int num1 = 20;
        int num2 = 10;

        Console.WriteLine("Addition: " + Add(num1, num2));
        Console.WriteLine("Subtraction: " + Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + Multiply(num1, num2));
        Console.WriteLine("Division: " + Divide(num1, num2));
    }
}
