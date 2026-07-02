namespace Task5_GradeLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Grade (Single Character only): ");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Pass");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

        }
    }
}
