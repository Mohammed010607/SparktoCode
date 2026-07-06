namespace Task6_Rectangle_Area___Perimiter_Function
{
    internal class Program
    {
        static double CalculateArea(double length, double width) {

            return length * width;
        }

        static double CalculatePerimiter(double length, double width) { 
        
            return 2*(length + width);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Lenght of the Rectangle: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width of the Rectangle: ");
            double w = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Area is: "+CalculateArea(l, w));
            Console.WriteLine("The Perimiter is: "+CalculatePerimiter(l, w));
        }
    }
}
