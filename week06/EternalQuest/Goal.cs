using System;

public abstract class Goal
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string title, string description, int points)
    {
        Title = title;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract string GetDetails();
}
