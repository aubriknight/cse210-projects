using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        List<Entry> myEntries = new List<Entry>();
        Entry one = new Entry();
        Console.WriteLine("");
        string Entry = Console.ReadLine();


        foreach (Entry e in myEntries)
        {
            e.Display();
        }
    }
}