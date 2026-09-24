using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int y = 0;
        
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int x = int.Parse(magicNumber);

        
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 20);


        while (x != y)
        {
            Console.Write("What is your guess? ");
            string guessedNumber = Console.ReadLine();
            y = int.Parse(guessedNumber);
        


            if (x > y)
            {
                Console.WriteLine("Guess higher");
            }
            else if (x < y)
            {
                Console.WriteLine("Guess lower");
            }
        }

        Console.WriteLine("Correct");

    }
}