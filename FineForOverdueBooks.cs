using System;
using static System.Console;

public class FineForOverdueBooks
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of books checked out:");
        int books = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of overdue days:");
        int days = Convert.ToInt32(Console.ReadLine());

        DisplayFine(books, days);
    }

    public static void DisplayFine(int books, int days)
    {
        double amt = 0;

        if (days <= 7)
        {
            amt = books * days * 0.10;
        }
        else
        {
            amt = books * 7 * 0.10;

            amt += books * (days - 7) * 0.20;
        }

        Console.WriteLine("The fine for {0} book(s) for {1} day(s) is ${2:F2}", books, days, amt);
    }
}