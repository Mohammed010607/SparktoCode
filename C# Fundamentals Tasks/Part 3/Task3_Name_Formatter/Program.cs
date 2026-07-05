namespace Task3_Name_Formatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            string uppercaseName = name.ToUpper();
            string lowercaseName = name.ToLower();
            int nameLength = name.Length;

            Console.WriteLine("Your name in uppercase: " + uppercaseName);
            Console.WriteLine("Your name in lowercase: " + lowercaseName);
            Console.WriteLine("The length of your name is: " + nameLength);
        }
    }
}
