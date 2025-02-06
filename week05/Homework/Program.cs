using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Lucy Ofori", "Creative Arts");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("David Koomson", "Trigonometry", "1.3", "15-21");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("King Joseph", "African History", "The Slave Trade");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
