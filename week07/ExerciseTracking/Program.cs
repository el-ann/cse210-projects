using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 3, 1), 30, 3.0),
            new Cycling(new DateTime(2025, 4, 1), 30, 20.0),
            new Swimming(new DateTime(2025, 5, 1), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
