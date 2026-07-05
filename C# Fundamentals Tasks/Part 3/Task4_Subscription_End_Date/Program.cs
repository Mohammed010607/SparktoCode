namespace Task4_Subscription_End_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Days for The Free Trial: ");
            int trial = int.Parse(Console.ReadLine());
            DateTime currentTiming = DateTime.Now;
            Console.WriteLine("Your Subscription Starts on: " + currentTiming);
            DateTime currentDate = DateTime.Today;
            DateTime subscriptionStartDate = DateTime.Today;
            DateTime subscriptionEndDate = subscriptionStartDate.AddDays(trial);
            Console.WriteLine("Your Subscription Ends on: " + subscriptionEndDate.ToString("yyyy-MM-dd"));

        }
    }
}
