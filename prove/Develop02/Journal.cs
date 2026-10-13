namespace Prompt;

class Journal
{
    // attributes
    public List<Entry> _entries = new List<Entry>();


    // behaviors
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._prompt = parts[1];
            loadedEntry._response = parts[2];

            _entries.Add(loadedEntry);
        }
    }
}