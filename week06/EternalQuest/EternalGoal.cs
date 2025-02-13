using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
        : base(title, description, points)
    {
    }

    public override void RecordEvent()
    {
        Points += 100; // Add 100 points for each event
    }

    public override string GetDetails()
    {
        return $"{Title}: {Description} - Points: {Points}";
    }
}
