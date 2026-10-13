namespace Prompt;

class Entry
{
    // attributes
    public string _date;
    public string _prompt;
    public string _response;

    // behaviors
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}