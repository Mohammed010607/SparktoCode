namespace Task11_LoanEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your monthly Income: ");
            double income = double.Parse(Console.ReadLine());
            Console.WriteLine("Do You Have an Existing Loan (Y/N): ");
            bool loan = Console.ReadLine() == "Y";

            if (age >= 21 && age <=60 && income >=400 && loan != true)
            {
                Console.WriteLine("You are Eligable for a Loan. ");
            }
            else
            {
                if (age < 21 || age > 60)
                {
                    Console.WriteLine("You are not Eligable for a Loan due to Age Restriction. ");
                }
                else if (income < 400)
                {
                    Console.WriteLine("You are not Eligable for a Loan due to Income Restriction. ");
                }
                else if (loan == true)
                {
                    Console.WriteLine("You are not Eligable for a Loan due to Existing Loan. ");
                }
            }
        }
    }
}
