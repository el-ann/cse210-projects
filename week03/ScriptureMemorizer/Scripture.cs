using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string text, Reference reference)
    {
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        _reference = reference;
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            while (true)
            {
                int index = random.Next(_words.Count);
                if (!_words[index].IsHidden())
                {
                    _words[index].HideWord();
                    break;
                }
            }
        }
    }

    public void RevealScripture()
    {
        foreach (var word in _words)
        {
            word.RevealWord();
        }
    }

    public void DisplayScripture()
    {
        foreach (var word in _words)
        {
            Console.Write(word.IsHidden() ? new string('_', word.GetText().Length) : word.GetText());
            Console.Write(" ");
        }
        Console.WriteLine($"\n\nReference: {_reference.GetDisplay()}");
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
