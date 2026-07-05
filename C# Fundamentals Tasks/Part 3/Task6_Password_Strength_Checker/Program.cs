namespace Task6_Password_Strength_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();

            if(password.ToLower().Contains("password") || password.Length < 8)
            {
                Console.WriteLine("Cannot contain word 'password' & cannot be less than 8 characters");
            }
            else
            {
                Console.WriteLine("Strong Password");
            }
        }
    }
}
