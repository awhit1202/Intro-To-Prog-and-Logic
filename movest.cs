using System;
using static System.Console;
using System.Globalization;


class MoveEstimator {
  static void Main() {
    
    // declare the constants for the RATES
    const double BASE_RATE = 200;
    const double RATE_PER_HOUR = 150;
    const double RATE_PER_MILE = 2;
    
    // variables to store the hours, miles and estimateAmount
    double hours, miles;
    double estimateAmount;
    
    // prompt user to enter the hours
    Console.Write("Enter the number of hours: ");
    hours = Convert.ToDouble(Console.ReadLine());
    
    
    // prompt user to enter the number of miles
    Console.Write("Enter the number of miles: ");
    miles = Convert.ToDouble(Console.ReadLine());
    
    // calculate the estimated amount using the formula -
    estimateAmount = BASE_RATE + RATE_PER_HOUR*hours + RATE_PER_MILE*miles;
    
    
    // display the amount with the currency symbol
    Console.WriteLine("Estimated Amount: {0}",
        estimateAmount.ToString("C",CultureInfo.GetCultureInfo("en-US"))
    );
    
    
  }
}
