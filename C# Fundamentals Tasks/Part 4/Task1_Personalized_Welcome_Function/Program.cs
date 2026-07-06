namespace Task1_Personalized_Welcome_Function
{
    internal class Program
    {

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Hello "+name);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
             
        }
    }
}
