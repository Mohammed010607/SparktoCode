using System;

namespace Task5_Grade_Rounding_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your raw exam score (e.g. 74.6): ");
            string input = Console.ReadLine();

            double score = double.Parse(input);
            double roundedScore = Math.Round(score, 0);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Fail");
            }
        }
    }
}