using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbersList = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            string enteredNumber = Console.ReadLine();
            number = int.Parse(enteredNumber);

            numbersList.Add(number);
        }

        int sum = 0;
        foreach (int num in numbersList)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbersList[0];

        foreach (int num in numbersList)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}