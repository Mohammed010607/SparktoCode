namespace Task9_RoundUp_RoundDown_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Decimal Number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double nearest = Math.Round(number);
            Console.WriteLine("Rounded to the nearest whole number: " + nearest);
            double roundedUp = Math.Ceiling(number);
            Console.WriteLine("Rounded up to the nearest whole number: " + roundedUp);
            double roundedDown = Math.Floor(number);
            Console.WriteLine("Rounded down to the nearest whole number: " + roundedDown);
        }
    }
}
