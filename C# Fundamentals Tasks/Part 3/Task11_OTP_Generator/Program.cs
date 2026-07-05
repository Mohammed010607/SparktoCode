namespace Task11_OTP_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random range = new Random();
           int otp = range.Next(1000, 10000);
            Console.WriteLine("Your OTP is: "+otp);

            int attempts = 0;
            bool verified = false;

            while(attempts < 3 && !verified)
            {
                Console.WriteLine("Enter the OTP to verify: ");
                string input = Console.ReadLine();

                try
                {
                   int enteredOtp = int.Parse(input);
                    if (enteredOtp == otp)
                    {
                        Console.WriteLine("Verified");
                        verified = true;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Incorrect OTP");
                    }
                }
                catch (FormatException)
                {
                    attempts++;
                    Console.WriteLine("Invalid input. Please enter a numeric OTP.");
                }
                if (!verified)
                {
                    Console.WriteLine("Verifivation failed.");
                }
            }
        }
    }
}
