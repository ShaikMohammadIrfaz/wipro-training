using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int number = 10;
        Console.WriteLine("Factorial of 10: " + Factorial(number));
    }
}
