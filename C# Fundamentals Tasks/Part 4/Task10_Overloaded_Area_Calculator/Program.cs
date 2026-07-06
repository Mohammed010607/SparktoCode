namespace Task10_Overloaded_Area_Calculator
{
    internal class Program
    {


        static double CalculateArea(double l)
        {
            return l * l;
        }
        static double CalculateArea(double l, double w) {
            return l*w;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Which Shape do You Want to Calculate the Area Of: ");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "square")
            {
                Console.WriteLine("Area of The Square is: " + CalculateArea(6, 2));
            }
            else if (userInput == "rectangle")
            {
                Console.WriteLine("The Area of The Rectangle is: "+  CalculateArea(2, 4));
            }
            else
            {
                Console.WriteLine("Ivalid Input, Select Either 'Square' or 'Rectangle'. ");  
            }
        }
    }
}
