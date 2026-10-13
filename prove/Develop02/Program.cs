using System;
namespace Prompt;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Please select one of the options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Which one would you like to do? ");

            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (option == 1)
            {
                Random rand = new Random();
                string prompt = prompts[rand.Next(prompts.Count)];

                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._response = response;

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added.\n");
            }
            else if (option == 2)
            {
                journal.Display();
            }
            else if (option == 3)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.Load(filename);
                Console.WriteLine("Journal loaded.\n");
            }
            else if (option == 4)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
                Console.WriteLine("Journal saved.\n");
            }
            else if (option == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}

