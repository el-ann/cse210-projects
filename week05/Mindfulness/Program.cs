using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.Start();
        }
    }
}

/*
 * Extra Features:
 * - Added a Listing Activity where users can list positive things about their life.
 * - The program counts and shows how many items the user listed in the Listing Activity.
 * - Used a spinner animation to show when the program is waiting or pausing.
 * - Created a main Activity class and separate classes for each specific activity (Breathing, Reflection, Listing).
 * - Provided clear prompts and questions to help users with the mindfulness exercises.
 */

