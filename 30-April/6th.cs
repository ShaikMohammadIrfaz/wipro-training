using System;

public class Exercise4
{
    public static void Main(string[] args)
    {
        int i = 1;

        while (i * i <= 100)
        {
            Console.WriteLine("Square of " + i + " = " + (i * i));
            i++;
        }
    }
}
