using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);
        // int y = 1;
        string gradeForClass = "";

        if (x >= 90)
        {
            gradeForClass = "A";
        }
        else if (x >= 80)
        {
            gradeForClass = "B";
        }
        else if (x >= 70)
        {
            gradeForClass = "C";
        }
        else if (x >= 60)
        {
            gradeForClass = "D";
        }
    
        else
        {
            gradeForClass = "F";
        }

        Console.WriteLine($"Your Grade is a {gradeForClass}");

        if (x >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass.");
        }

    }
}