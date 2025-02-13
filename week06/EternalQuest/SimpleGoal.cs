using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string title, string description, int points)
        : base(title, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetDetails()
    {
        return $"{Title}: {Description} - Points: {Points}, Complete: {_isComplete}";
    }
}
