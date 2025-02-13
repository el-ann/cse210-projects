using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal()
    {
        Console.WriteLine("Choose the type of goal to add:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the title of the goal: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(title, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.Write("Enter the required number of completions: ");
                int requiredCount = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, requiredCount, bonusPoints);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _totalScore += goal.Points;
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public int GetTotalScore()
    {
        return _totalScore;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Title);
                writer.WriteLine(goal.Description);
                writer.WriteLine(goal.Points);
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.GetDetails());
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _totalScore = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string title = reader.ReadLine();
                string description = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());

                if (goalType == nameof(SimpleGoal))
                {
                    SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                    _goals.Add(simpleGoal);
                }
                else if (goalType == nameof(EternalGoal))
                {
                    EternalGoal eternalGoal = new EternalGoal(title, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    int requiredCount = int.Parse(reader.ReadLine());
                    int bonusPoints = int.Parse(reader.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, requiredCount, bonusPoints);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}
