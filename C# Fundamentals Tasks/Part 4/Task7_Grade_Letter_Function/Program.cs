namespace Task7_Grade_Letter_Function
{
    internal class Program
    {

        static string GetGradeLetter(double score)
        {

            if(score >= 80 && score <= 100)
            {
                return "A";
            }
            else if(score <= 79 && score >= 70)
            {
                return "B";
            }
            else if(score <= 69 && score >= 60)
            {
                return "C";
            }
            else if(score <= 59 && score >= 50)
            {
                return"D";
            }
            else
            {
                return "F";
            }
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Exam Score: ");
            double userScore = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Grade is: " + GetGradeLetter(userScore));
        }
    }
}
