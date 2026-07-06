namespace Task5_Even_Or_Odd_Function
{
    internal class Program
    {

        static bool isEven(int num)
        {
            return num % 2 == 0;
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (isEven(userInput))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
