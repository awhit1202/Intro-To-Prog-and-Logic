using System;
// Class named TestScoreList
class TestScoreList
{
    static void Main(String[] args)
    {
        int[] scores = new int[8];
        double average = 0;
        int sum = 0;
        for(int i = 0; i < scores.Length; i++)
        {
            Console.Write("Enter Score " + (i + 1) + ": ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            sum = sum + scores[i];
        }
        average = (double)sum / scores.Length;
        Console.WriteLine("Average is: " + average);
        for(int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Test # " + i + ": " + scores[i] + " From average: " + (scores[i] - average));
        }
    }
}