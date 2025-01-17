using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Tech Innovators Corporation", 2021, 2023);

        job1.Display();

        Job job2 = new Job("Data Analyst", "Data Solutions Limited", 2023, 2025);

        job2.Display();   

        Resume myResume = new Resume("Elizabeth Ann Adjabeng");

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        Console.WriteLine("First Job Title: " + myResume.Jobs[0].JobTitle);

        myResume.DisplayResume();
    }
}
