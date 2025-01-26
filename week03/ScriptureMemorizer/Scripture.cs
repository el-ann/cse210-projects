public class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(string text, Reference reference)
    {
        words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
        this.reference = reference;
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            while (true)
            {
                int index = random.Next(words.Count);
                if (!words[index].IsHidden())
                {
                    words[index].HideWord();
                    break;
                }
            }
        }
    }

    public void RevealScripture()
    {
        foreach (var word in words)
        {
            word.RevealWord();
        }
    }

    public void DisplayScripture()
    {
        foreach (var word in words)
        {
            Console.Write(word.IsHidden() ? new string('_', word.GetText().Length) : word.GetText());
            Console.Write(" ");
        }
        Console.WriteLine($"\n\nReference: {reference.GetDisplayText()}");
    }

    public bool AllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
