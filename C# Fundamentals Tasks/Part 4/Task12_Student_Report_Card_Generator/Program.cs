using System;

namespace Task_Report_Card_Generator
{
    internal class Program
    {
        static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3;
        }

        static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void PrintReportCard(string name, double average, string gradeLetter)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Grade: " + gradeLetter);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter first subject score: ");
            double score1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second subject score: ");
            double score2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third subject score: ");
            double score3 = Convert.ToDouble(Console.ReadLine());
            double average = CalculateAverage(score1, score2, score3);
            string gradeLetter = GetGradeLetter(average);
            PrintReportCard(name, average, gradeLetter);
        }
    }
}