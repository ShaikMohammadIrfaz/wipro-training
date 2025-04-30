using System;

public class Exercise2
{
    public static void Main(string[] args)
    {
        int num = 1234;
        int sum = 0;

        while (num != 0)
        {
            int digit = num % 10;
            sum += digit;
            num /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
