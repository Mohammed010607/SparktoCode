namespace Task11_Function_Based_Calculator
{
    internal class Program
    {

        static double AddNumbers(double a, double b)
        {
            return a + b;
        }
        static double SubtractNumbers(double a, double b) { 
            return a - b;
        }
        static double MultiplyNumbers(double a, double b) { 
            return a * b; 
        }
        static double DivideNumbers(double a, double b) {

            try
            {
                if (b == 0)
                {
                    return 0;
                }
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant Divide By Zero.");
                return 0;
            }

        }
        static void DisplayResults(string operationName, double result)
        {
            Console.WriteLine("Operation: " + operationName);
            Console.WriteLine("Result: "+ result);
        }




        static void Main(string[] args)
        {
            double choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Select an operation Number (1-5): ");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting.");
                    break;
                }
                Console.WriteLine("Enter The First Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Second Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice) {
                    case 1:
                        DisplayResults("Addition", AddNumbers(num1, num2));
                        break;
                    case 2:
                        DisplayResults("Subtraction", SubtractNumbers(num1, num2));
                        break;
                    case 3:
                        DisplayResults("Multiplication", MultiplyNumbers(num1, num2));
                        break;
                    case 4:
                        DisplayResults("Division", DivideNumbers(num1, num2));
                        break;
                }
            }
        }
    }
}
