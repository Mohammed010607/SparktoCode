namespace Task1_Absolute_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second Number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = Math.Abs(num1 - num2);
            Console.WriteLine("The Absolute Difference Between the Two Numbers is: " + result);
        }
    }
}
