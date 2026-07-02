namespace Task9_DayNameFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer between 1 and 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter an integer between 1 and 7.");
                    break;
            }
        }
    }
}
