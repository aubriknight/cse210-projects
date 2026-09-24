using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }
        // DisplayWelcome - Displays the message, "Welcome to the Program!"

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // PromptUserName - Asks for and returns the user's name (as a string)

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        // PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. 
        // The out parameter is set to their birth year. This function does not return a value. 
        // The user's birth year is given back from the function via the out parameter.

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What is your birth year? ");
            birthYear = int.Parse(Console.ReadLine());

        }

        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // DisplayResult - Accepts the user's name, the squared number, and the user's birth year. 
        // Display the user's name and squared number. 
        // Calculate hold many years old they will turn this year and display that.
        
        static void DisplayResult(string name, int square, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
            Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
        }
}