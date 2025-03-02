using System;

class Twitter
{
    static void Main(string[] args)
    {
        // Step 1: Accept the user's message
        Console.WriteLine("Enter your message:");
        string? message = Console.ReadLine(); // Nullable string to handle null case

        // Step 2: Check if message is null before accessing Length
        if (message == null)
        {
            Console.WriteLine("No message entered.");
        }
        else
        {
            // Step 3 and 4: Compare the length with 140 and output the appropriate message
            int length = message.Length;

            if (length > 140)
            {
                Console.WriteLine("The message is too long.");
            }
            else
            {
                Console.WriteLine("The message is okay.");
            }
        }
    }
}