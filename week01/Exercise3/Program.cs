using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Random randomNumber = new Random();
                int magicNumber = randomNumber.Next(1, 101);

                int guess = -1; 
                int numberOfGuesses = 0; 
                while (guess != magicNumber)
                {
                    Console.WriteLine("What is your guess?");
                    guess = int.Parse(Console.ReadLine());
                    numberOfGuesses++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                    }
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "yes";
            }
        }
    }
