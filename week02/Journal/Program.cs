using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Console.Write("Enter your mood: ");
                string mood = Console.ReadLine();

                Console.Write("Enter your location: ");
                string location = Console.ReadLine();

                Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response, mood, location);
                myJournal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                // Display the journal
                myJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                // Save the journal to a file
                Console.Write("Enter the filename to save the journal: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userInput == "4")
            {
                // Load the journal from a file
                Console.Write("Enter the filename to load the journal: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
        }
    }

    // Description of enhancements:
    // - Applied the principle of Abstraction by encapsulating entry data and journal management in separate classes.
    // - Enhanced user prompts to be more descriptive.
    // - Added comments explaining the code and the abstraction used.
}
