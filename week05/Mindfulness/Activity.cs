using System;
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        Console.Write("Enter the duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 
        ExecuteActivity();
        End();
    }

    protected abstract void ExecuteActivity();

    protected void End()
    {
        Console.WriteLine($"You have completed the {name} for {duration} seconds. Great job!");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}
