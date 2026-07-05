namespace Task8_Membership_Expiry_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Membership Start Date (2026-01-10): ");
            string startDateInput = Console.ReadLine();
            Console.WriteLine("Enter Number of Valid Membership Days: ");
            string duration = Console.ReadLine();
            try
            {
                DateTime startDate = DateTime.Parse(startDateInput);
                int validityPeriod = int.Parse(duration);
                DateTime expiryDate = startDate.AddDays(validityPeriod);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Your membership is still valid. Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
                }
                else
                {
                    Console.WriteLine("Your membership has expired. Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format");
            }
        }
    }
}
