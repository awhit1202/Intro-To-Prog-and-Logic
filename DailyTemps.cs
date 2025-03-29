using System;
using static System.Console;
class DailyTemps
{
    static void Main()
    {
        //declare a variable named temperature to hold the temperature entered by the user
        double temperature = 0;
        //declare a variable named count to keep a track of valid temperatures
        int count = 0;
        //declare a variable named total to keep a track of sum of valid temperatures
        double total=0;
        // An infinite loop to continuously prompt the user for input
        while (true)
        {
            // Prompt the user to enter temperature 
            Console.Write("Enter the daily high temperature (-20 to 130) or 999 to quit: ");
            
            // Read input "temperature" from user
            temperature = double.Parse(ReadLine());
            // Check if the entered input is a sentinel value 999
            if (temperature == 999)
            {
                //if true, exit the loop 
                break; 
            }
            //check if the temperature is a valid temperature or not
            //valid range is -20 to 130
            if (temperature >= -20 && temperature <= 130)
            {
                //Add valid temperature to total and increment the count
                total += temperature;
                count++; 
            }
            //if  the temperature is not a valid temperature, display error message 
            else
            {
                Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature");
            }
        }        
        // If there are valid temperatures, then display the results
        if (count > 0)
        {
            //display the number of valid temperature entered
            Console.WriteLine($"Number of valid temperatures entered: {count}");
            //calculate and display average of valid temperatures
            Console.WriteLine($"Average of valid temperatures: {total/count}");
        }
        else
        {   //if there are no valid temperatures entered, then display the message
            Console.WriteLine("No valid temperatures were entered.");
        }
    }
}