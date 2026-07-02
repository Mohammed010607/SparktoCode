namespace Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Positive Integer: ");
            int num = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 1; i <= num; i++) {
                result += i;
            }
            Console.WriteLine("Result = " + result);
        }
    }
}
