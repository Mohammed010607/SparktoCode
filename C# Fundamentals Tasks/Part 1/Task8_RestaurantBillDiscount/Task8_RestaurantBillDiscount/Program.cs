namespace Task8_RestaurantBillDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your total bill amount: ");
            double bill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you a member? (Y/N): ");
            bool isMember = Console.ReadLine() == "Y";

            double discount = 0;

            if (isMember == true && bill > 20)
            {
                Console.WriteLine("Your Original Bill Was: " + bill);
                discount = bill * 0.15;
                Console.WriteLine("Your Discount Amount is: " + discount);
                double finalBill = bill - discount;
                Console.WriteLine("Your Final Bill Amount is: " + finalBill);
            }
            else
            {
                Console.WriteLine("You are not eligible for a discount.");
                Console.WriteLine("Your Bill is: " + bill);
            }


        }
    }
}
