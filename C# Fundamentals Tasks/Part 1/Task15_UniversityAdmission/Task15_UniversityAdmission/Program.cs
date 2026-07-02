namespace Task15_UniversityAdmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Program (A = Art, S = Science): ");
            string program = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Your GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Exam Score: ");
            double examScore = double.Parse(Console.ReadLine());
            Console.WriteLine("Do you have extracurricular activities (y/n): ");
            bool extracurricular = Console.ReadLine().ToLower() == "y";

            switch (program)
            {
                case "S":
                    Console.WriteLine("Program: Science");
                    if (gpa >= 3.0 && examScore >= 75)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (extracurricular)
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;

                case "A":
                    Console.WriteLine("Program: Art");
                    if (gpa >= 2.5 && examScore >= 60)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (extracurricular)
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid program.");
                    break;
            }
        }
    }
}
