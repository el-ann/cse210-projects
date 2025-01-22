using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}|{entry.Mood}|{entry.Location}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    string date = parts[0].Trim('"');
                    string promptText = parts[1].Replace("|", "~").Trim('"');
                    string entryText = parts[2].Replace("|", "~").Trim('"');
                    string mood = parts[3].Replace("|", "~").Trim('"');
                    string location = parts[4].Replace("|", "~").Trim('"');
                    Entry newEntry = new Entry(date, promptText, entryText, mood, location);
                    entries.Add(newEntry);
                }
            }
        }
    }
}
