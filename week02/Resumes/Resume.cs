using System;

public class Resume
{
    private string _name;

    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Job> Jobs
    {
        get { return _jobs; }
        set { _jobs = value; }
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
