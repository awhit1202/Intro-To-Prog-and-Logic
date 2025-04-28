using System;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the room in feet:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the room in feet:");
            double width = Convert.ToDouble(Console.ReadLine());

            double cost = CalculatePaintingCost(length, width);

            Console.WriteLine($"The cost to paint the room is: ${cost:F2}");
        }

        static double CalculatePaintingCost(double length, double width)
        {
            double height = 9.0;

            double wallArea = 2 * height * (length + width);

            double pricePerSquareFoot = 6.0;

            double totalCost = wallArea * pricePerSquareFoot;

            return totalCost;
        }
    }
}