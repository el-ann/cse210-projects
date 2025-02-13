using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.AddGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    Console.Write("Enter goal number to record event: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    goalManager.RecordEvent(goalIndex);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {goalManager.GetTotalScore()}");
                    break;
                case "5":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;
                case "6":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

/*
 * Extra Features:
 * 
 * - Created a GoalManager class to keep track of goals and scores.
 * - Added the ability to save and load goals and scores from files.
 * - Improved the checklist goals to give extra points when all tasks are done.
 * - Added more messages and instructions to help users understand what to do.
 * - Made the code in small, separate parts to make it easier to manage and add new features.
 */
