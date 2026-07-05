namespace Task2_Power___Root_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number: ");
            double num = double.Parse(Console.ReadLine());

            double squareRoot = Math.Sqrt(num);
            double square = Math.Pow(num, 2);

            Console.WriteLine("The Square Root of " + num + " is: " + squareRoot);
            Console.WriteLine(num + " Squared is: "+square);
        }
    }
}
