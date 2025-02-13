using System;

public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _requiredCount;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int requiredCount, int bonusPoints)
        : base(title, description, points)
    {
        _completedCount = 0;
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        Points += 50; // Add points for each event
        if (_completedCount >= _requiredCount)
        {
            Points += _bonusPoints; // Add bonus points when goal is completed
        }
    }

    public override string GetDetails()
    {
        return $"{Title}: {Description} - Points: {Points}, Completed: {_completedCount}/{_requiredCount}";
    }
}
