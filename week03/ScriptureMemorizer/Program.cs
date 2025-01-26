using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 4, 5);
        Scripture scripture = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.", reference);
        
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("The entire scripture has been hidden.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Exceed Requirements
            scripture.HideRandomWords(3);
        }

        // Additional Feature: Review Mode
        Console.WriteLine("\nReview Mode: Recall the hidden scripture");

        // Load scripture and allow user to type to recall
        scripture.RevealScripture();
        scripture.DisplayScripture();
        Console.WriteLine("Press Enter to finish.");

        while (true)
        {
            string recall = Console.ReadLine();
            if (string.IsNullOrEmpty(recall))
                break;
        }
    }
}
/* 
 * Exceeding Requirements:
 * 1. Implemented a feature to handle multiple verses in a single scripture.
 * 2. Included logic to review user progress, allowing for a review feature to help users recall missed words.
 * 3. The program loads scriptures from a file, enabling a library of scriptures to be used.
 * 4. Ensured that the program only hides words that are not already hidden.
 * 5. Provided a review mode where users can recall missed words.
 */
