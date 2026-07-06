namespace Task2_Square_Number_Function
{
    internal class Program
    {
        static int Square(int number) {
            return number * number;
        }






        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sqare is: "+Square(num));
 
        }
    }
}
