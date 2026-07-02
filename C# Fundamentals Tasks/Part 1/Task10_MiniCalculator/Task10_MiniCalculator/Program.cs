namespace Task10_MiniCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operator (+, -, *, /, %): ");
            string op = Console.ReadLine();

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result : " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: "+ result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break; 
            }
        }
    }
}
