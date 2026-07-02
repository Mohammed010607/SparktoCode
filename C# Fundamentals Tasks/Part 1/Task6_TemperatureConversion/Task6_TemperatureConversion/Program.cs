namespace Task6_TemperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Temperature in Celsius: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double tempConversion = (temp * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is: " + tempConversion);

            if (temp < 10) {
                Console.WriteLine("It is Cold");
            }
            else if (temp > 10 && temp <= 30) {
                Console.WriteLine("It is Mild");
            }
            else {
                Console.WriteLine("It is Hot");
            }
        }
    }
}
