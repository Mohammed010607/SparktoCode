namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task 1 (Fixed Grade Array):

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
            

            //Task 2 (Dynamic To-Do List)
            List<string>toDoList = new List<string>();

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("Enter task " + (i + 1) + ": " );
                toDoList.Add(Console.ReadLine());
            }
            

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Task 3 (Browsing History Stack):

            Stack<string> history = new Stack<string>();
            Console.WriteLine("Enter 3 Website URLs: ");
            Console.WriteLine("");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("URL "+(i + 1).ToString() + ": ");
                string URL = Console.ReadLine();
                history.Push(URL);
            }
            string prevPage = history.Pop();
            Console.WriteLine("Previous Page is: " + prevPage);
          
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Task 4 (Customer Service Queue):

            Queue<string> waitingLine = new Queue<string>();
            Console.WriteLine("Enter 3 Customer Nmaes: ");
            Console.WriteLine("");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Customer "+(i+1)+": ");
                waitingLine.Enqueue(Console.ReadLine());
            }
            Console.WriteLine("First Customer in Line is: "+ waitingLine.Dequeue());
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 5 (Array Grade Rang):

            int[] gradeArray = new int[5];
            Console.WriteLine("Enter Your 5 Grades: ");
            for(int i = 0; i <gradeArray.Length; i++)
            {
                Console.WriteLine("Enter Grade "+(i+1)+": ");
                gradeArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(gradeArray);
            int sum = 0;
            foreach(int mark in gradeArray)
            {
                sum += mark;
            }
            double average = sum / 5;
            Console.WriteLine("Lowest Mark: " + gradeArray[0]);
            Console.WriteLine("Highest Mark: " + gradeArray[gradeArray.Length-1]);
            Console.WriteLine("Your Agerage Mark is: " + gradeArray.Average());
           
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Task 6 (Filtering Shopping List)
            List<string> shoppingList = new List<string>();
            string stopping = "";
            stopping.ToLower();
            Console.WriteLine("Add Your Shopping List Items (type 'done' to finish): ");
            while(stopping != "done")
            {
                if(stopping != "done")
                {
                    shoppingList.Add(Console.ReadLine());
                } 
                
            }
            Console.WriteLine("");
            Console.WriteLine("Remove One Item From The List. ");
            string remove = Console.ReadLine();
            shoppingList.Remove(remove);
            Console.WriteLine("");
            Console.WriteLine("The Final Shopping List is: ");
            foreach (string entry in shoppingList) {
                Console.WriteLine(entry);
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 7 (High Score Podium): 

            List<int> gameScores = new List<int>();
            Console.WriteLine("Enter 5 Game Scores: ");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Score Fore Game "+(i+1)+": ");
                gameScores.Add(Convert.ToInt32(Console.ReadLine()));
            }
            gameScores.Sort();
            gameScores.Reverse();
            Console.WriteLine("");
            Console.WriteLine("Podium: ");
            Console.WriteLine("1st Place: " + gameScores[0]);
            Console.WriteLine("2nd Place: " + gameScores[1]);
            Console.WriteLine("3rd Place: " + gameScores[2]);
        }
    }
}
