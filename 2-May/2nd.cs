using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string or number: ");
        string input = Console.ReadLine();
        
        string reversed = ReverseString(input);

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("It is a Palindrome.");
        else
            Console.WriteLine("It is not a Palindrome.");
    }

    static string ReverseString(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
