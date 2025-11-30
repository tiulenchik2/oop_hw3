using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter int number:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"You entered {number}");
        }
        else
        {
            Console.WriteLine("Error: entered invalid number.");
        }
    }
}
