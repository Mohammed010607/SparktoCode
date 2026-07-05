namespace Task7_Clean_Name_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Same Name Twice (with different casings and spacing): ");
            Console.WriteLine("Enter the Name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter the Name Again: ");
            string name2 = Console.ReadLine();

            name1 = name1.ToUpper().Trim();
            name2 = name2.ToUpper().Trim();
            
            if(name1 == name2)
            {
                Console.WriteLine("The Names are the Same");
            }
            else
            {
                Console.WriteLine("The Names are Different");
            }
        }
    }
}
