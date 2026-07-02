namespace Task7_MovieTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double ticketPrice = 0;
            if(age > 0 && age <= 12)
            {
                Console.WriteLine("You are a child: ");
                Console.WriteLine("Your ticket price is 2.000 OMR");
            }
            else if (age > 12 && age <= 59)
            {
                Console.WriteLine("You are an adult: ");
                Console.WriteLine("Your ticket price is 5.000 OMR");
            }
            else
            {
                Console.WriteLine("You are a senior: ");
                Console.WriteLine("Your ticket price is 3.000 OMR");
            }
        }
    }
}
