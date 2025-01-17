using System;

public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
