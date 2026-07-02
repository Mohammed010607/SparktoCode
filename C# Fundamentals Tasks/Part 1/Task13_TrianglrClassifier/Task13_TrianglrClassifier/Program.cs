namespace Task13_TrianglrClassifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Lenght of 3 Sides of the Triangle. ");
            Console.WriteLine("Enster Length of Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enster Length of Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enster Length of Side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) {
                if (side1 == side2 && side2 == side3) { 
                    Console.WriteLine("The Triangle is Equilateral.");
                }
                else if(side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The Triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The Triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The sides dont add up to a triangle.");
            }
        }
    }
}
