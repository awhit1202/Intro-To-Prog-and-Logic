using System;
using static System.Console;
class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Please enter a valid integer: ");
        }

        Console.WriteLine($"\nMultiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            int product = i * number;
            Console.WriteLine($"{i} x {number} = {product}");
        }
    }
}