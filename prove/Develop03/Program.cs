using System;

class Program
{
    static void Main(string[] args)
    {
        // 3 classes 
        // scripture, reference, word 

        // insert the scripure data into the scripture class

        // insert the reference 

        // 

        // extra thing: add a word count to how many words are left?

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding");
    
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayString());

            // Extra: word count
            Console.WriteLine($"Words Remaining: {scripture.WordsRemaining()}");

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type quit:");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }
    }
}