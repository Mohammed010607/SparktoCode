namespace Task3_Celsius_To_Farenheit_Function
{
    internal class Program
    {
        static double CelsiusToFarenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }









        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Temperature in Celsius: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            double farenheit = CelsiusToFarenheit(temp);
            Console.WriteLine("The Temperature in Farenheit is: "+farenheit);
        }
    }
}
