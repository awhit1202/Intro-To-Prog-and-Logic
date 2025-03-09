// hurricaneproj.cs
using System;
using static System.Console;
class Hurricane
{
    // Main() method of execution.
	static void Main(string[] args)
	{

		Console.Write("Enter wind speed (in miles per hour): ");
		
		double windSpeed = Convert.ToDouble(Console.ReadLine());
		
        int category = 0;
        
		if (windSpeed < 74)
		{
			Console.WriteLine("This is not a hurricane.");
		}
		
		else
		{

			if (windSpeed >= 157)
			{
				category = 5;
			}
			
			else if (windSpeed >= 130)
			{
				category = 4;
			}
			
			else if (windSpeed >= 111)
			{
				category = 3;
			}
			
			else if (windSpeed >= 96)
			{
				category = 2;
			}
			
			else
			{
				category = 1;
			}

			// Display the category of the hurricane
			Console.WriteLine("This is a category " + category + " hurricane");
		}
	}
}