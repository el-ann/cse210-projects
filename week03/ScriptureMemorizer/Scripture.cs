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
            int index = random.Next(words.Count);
            words[index].HideWord();
        }
    }

    public void DisplayScripture()
    {
        foreach (var word in words)
        {
            Console.Write(word.IsHidden() ? "_____" : word.GetText());
            Console.Write(" ");
        }
        Console.WriteLine($"\n\nReference: {reference.GetDisplayText()}");
    }
}
