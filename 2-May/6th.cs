using System;

class Program
{
    static int CountZeros(int n)
    {
        if (n == 0)
            return 1;

        return CountZerosHelper(n);
    }

    static int CountZerosHelper(int n)
    {
        if (n == 0)
            return 0;
        int count = (n % 10 == 0) ? 1 : 0;
        return count + CountZerosHelper(n / 10);
    }

    static void Main()
    {
        int number = 10203040;
        Console.WriteLine("Number of zeros: " + CountZeros(number));
    }
}
