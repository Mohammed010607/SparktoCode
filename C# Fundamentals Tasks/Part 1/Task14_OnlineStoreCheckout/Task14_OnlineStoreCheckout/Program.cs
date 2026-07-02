namespace Task14_OnlineStoreCheckout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a product code (1 = CPU, 2 = GPU, 3 = PSU)");
            int productCode = Convert.ToInt32(Console.ReadLine());

            double price = 0;
            string productName = "";

            switch (productCode) 
            {

                case 1:
                    price = 150.00;
                    productName = "CPU";
                    break;

                case 2:
                    price = 300.00;
                    productName = "GPU";
                    break;

                case 3:
                    price = 100.00;
                    productName = "PSU";
                    break;

                default:
                    Console.WriteLine("Invalid product code.");
                   return;
            }

            Console.WriteLine("Enter the Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have a discount code? (y/n)");
            bool hasDiscountCode = Console.ReadLine() == "y";

            double total = price * quantity;
            double discount = 0;

            if (hasDiscountCode && total > 20)
            {
                discount = total * 0.10;
            }
            double postDiscountTotal = total - discount;
            double tax = postDiscountTotal * 0.05;
            double finalTotal = postDiscountTotal + tax;

            Console.WriteLine("Total is: " + total + "OMR");
            Console.WriteLine("Discount is: " + discount + "OMR");
            Console.WriteLine("Tax is: " + tax + "OMR");
            Console.WriteLine("Final Total is: " + finalTotal + "OMR");
        }
    }
}
