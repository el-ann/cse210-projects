using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their grade percentage
            Console.WriteLine("Enter your grade percentage:");
            int gradePercentage = int.Parse(Console.ReadLine());

            string letter;
            string sign = "";

            // Determine the letter grade
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine the sign
            if (letter != "A" && letter != "F")
            {
                int lastDigit = gradePercentage % 10;
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            // Handle exceptional cases
            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
            else if (letter == "F")
            {
                sign = "";
            }

            // Print the letter grade with the sign
            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            // Determine if the user passed the course
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Keep trying! You'll get it next time.");
            }
        }
    }
