namespace Task9_Overloaded_Multiply_Function
{
    internal class Program
    {

        static int Multiply(int a, int b) {
            return a * b;
        }
        static double Multiply(double a, double b) {
            return a * b; 
        }
        static int Multiply(int a, int b, int c) {
            return a * b * c;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("2 x 3 = " +Multiply(2, 3));
            Console.WriteLine("2.5 x 2.5 = " + Multiply(2.5, 2.5));
            Console.WriteLine("3 x 3 x 3  = " + Multiply(3, 3, 3));
        }
    }
}
