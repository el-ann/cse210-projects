public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }  

    public void DisplayAll()
    {
       foreach (var entry in _entries)
       {
           entry.Display();
       }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine(entry._mood);
                writer.WriteLine(entry._location);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(new string[] {"\",\""}, StringSplitOptions.None);
                if (parts.Length == 5)
                {
                    string date = parts[0].Trim('"');
                    string promptText = parts[1].Trim('"');
                    string entryText = parts[2].Trim('"');
                    string mood = parts[3].Trim('"');
                    string location = parts[4].Trim('"');
                    Entry newEntry = new Entry(date, promptText, entryText, mood, location);
                    _entries.Add(newEntry);
                }
            }
        }
    }

}
