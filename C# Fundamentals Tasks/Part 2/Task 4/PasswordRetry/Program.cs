namespace PasswordRetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passCode = "";
            while(passCode != "Spark2026") {
                Console.WriteLine("Please enter the password: ");
                passCode = Console.ReadLine();
            }
            Console.WriteLine("Access granted!");
        }
    }
}
