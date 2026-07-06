namespace Task8_Countdown_Function
{
    internal class Program
    {


        static void Countdown(int num)
        {
            for(int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Countdown(userInput);
              
        }
    }
}
