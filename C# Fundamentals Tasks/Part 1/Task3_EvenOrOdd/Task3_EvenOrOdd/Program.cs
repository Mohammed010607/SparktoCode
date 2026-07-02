namespace Task3_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Whole Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number input is even.");

            }
            else
            {
                Console.WriteLine("The number input is odd.");
            }
        }
    }
}
