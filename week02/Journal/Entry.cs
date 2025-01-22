using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _location;

    public Entry(string date, string promptText, string entryText, string mood, string location)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
        _location = location;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Location: {_location}");
    }
}
