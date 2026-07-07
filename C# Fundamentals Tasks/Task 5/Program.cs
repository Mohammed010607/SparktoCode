namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task 1 (Fixed Grade Array)
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter Grade: " + (i + 1) + ": " );
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Your Grades Are: ");
            foreach (int grade in grades) {
                
                Console.WriteLine(grade);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            */

            //Task 2 (Dynamic To-Do List)
            List<string>toDoList = new List<string>();

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("Enter task " + (i + 1) + ": " );
                toDoList.Add(Console.ReadLine());
            }
        }
    }
}
