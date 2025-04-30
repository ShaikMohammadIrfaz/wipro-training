using System;

public class Exercise3
{
    public static void Main(string[] args)
    {
        int num = 123;
        int reverse = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("Reversed number: " + reverse);
    }
}
