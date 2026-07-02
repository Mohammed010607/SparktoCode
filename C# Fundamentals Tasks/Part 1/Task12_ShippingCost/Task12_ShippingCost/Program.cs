namespace Task12_ShippingCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Region Code (A = Local, B = National, C = International): ");
            string region = Console.ReadLine();
            Console.WriteLine("Enter the Package Weight in KG: ");
            double weight = double.Parse(Console.ReadLine());


            double shippingCost = 0;
            double extraCost = 0;

            switch (region)
            {
                case "A":
                    shippingCost = 1.000;
                    if (weight > 10)
                    {
                        extraCost = 5.000;
                    }
                    else if (weight > 5)
                    {
                        extraCost = 2.000;
                    }
                    else
                    {
                        extraCost = 0.000;
                    }
                    Console.WriteLine("Base shipping cost: " + shippingCost + "OMR");
                    Console.WriteLine("Extra shipping cost: " + extraCost + "OMR");
                    Console.WriteLine("Total shipping cost: " + (shippingCost + extraCost) + "OMR");
                    break;
                case "B":
                    shippingCost = 3.000;
                    if (weight > 10)
                    {
                        extraCost = 5.000;
                    }
                    else if (weight > 5)
                    {
                        extraCost = 2.000;
                    }
                    else
                    {
                        extraCost = 0.000;
                    }
                    Console.WriteLine("Base shipping cost: " + shippingCost + "OMR");
                    Console.WriteLine("Extra shipping cost: " + extraCost + "OMR");
                    Console.WriteLine("Total shipping cost: " + (shippingCost + extraCost) + "OMR");
                    break;
                case "C":
                    shippingCost = 7.000;
                    if (weight > 10)
                    {
                        extraCost = 5.000;
                    }
                    else if (weight > 5)
                    {
                        extraCost = 2.000;
                    }
                    else
                    {
                        extraCost = 0.000;
                    }
                    Console.WriteLine("Base shipping cost: " + shippingCost + "OMR");
                    Console.WriteLine("Extra shipping cost: " + extraCost + "OMR");
                    Console.WriteLine("Total shipping cost: " + (shippingCost + extraCost) + "OMR");
                    break;
                default:
                    Console.WriteLine("Invalid Region");
                    break;
            }
        }
    }
}
