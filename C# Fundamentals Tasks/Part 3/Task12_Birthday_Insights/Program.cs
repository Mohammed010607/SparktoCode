namespace Task12_Birthday_Insights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Date of Birth (2000-05-14): ");
            string dobInput = Console.ReadLine();
            try
            {
                DateTime dob = DateTime.Parse(dobInput);
                DateTime today = DateTime.Today;
                int age = today.Year - dob.Year;

                if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                {
                    age--;
                }
                DayOfWeek birthDay = dob.DayOfWeek;
                Console.WriteLine("You are " + age + " years old.");
                Console.WriteLine("You were born on a " + birthDay + ".");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Date Format. Please enter the date in the format YYYY-MM-DD.");
            }
        }
    }
}
