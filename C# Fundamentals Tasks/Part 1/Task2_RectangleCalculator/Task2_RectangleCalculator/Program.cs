using System.Formats.Asn1;

namespace Task2_RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rectangle Height in cm: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rectangle Width in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimiter = 2 * (length + width);

            Console.WriteLine("The area of the rectancle is: " + area + " cm squared");
            Console.WriteLine("The perimeter of the rectangle is: " + perimiter + " cm");
        }
    }
}
