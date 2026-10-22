
class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayString()
    {
        string result = _reference.GetDisplayString();

        foreach (Word word in _words)
        {
            result += " " + word.GetDisplayString();
        }

        return result;
    }

    public void HideRandomWord()
    {
        Random random = new Random();

        int index = random.Next(_words.Count);

        while (_words[index].IsHidden())
        {
            index = random.Next(_words.Count);
        }

        _words[index].Hide();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Extra: word count
    public int WordsRemaining()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }
}