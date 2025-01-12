using System;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int number;

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            do
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    numbers.Add(number);
                }
            } while (number != 0);

            // Core Requirements
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is: {sum}");

            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge 1: Find the smallest positive number
            int? smallestPositive = null;
            foreach (int num in numbers)
            {
                if (num > 0 && (smallestPositive == null || num < smallestPositive))
                {
                    smallestPositive = num;
                }
            }
            if (smallestPositive != null)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Stretch Challenge 2: Sort the list and display it
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }