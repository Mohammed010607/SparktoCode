namespace Task10_Word_Position_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Full Sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter a Word to Find from the Sentence: ");
            string word = Console.ReadLine();

            int firstIndex = sentence.IndexOf(word);
            int lastIndex = sentence.LastIndexOf(word);

            if(firstIndex == -1)
            {
                Console.WriteLine("Word is not in the sentence.");
            }
            else
            {
                Console.WriteLine("The first occurrence of the word is at index: " + firstIndex);
                Console.WriteLine("The last occurrence of the word is at index: " + lastIndex);
            }

        }
    }
}

