using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance for 1/1 using the first constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction 1 (using first constructor):");
        fraction1.Display();
        Console.WriteLine("Value: " + fraction1.GetValue());

        // Create an instance for 6/1 using the second constructor
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine("\nFraction 2 (using second constructor):");
        fraction2.Display();
        Console.WriteLine("Value: " + fraction2.GetValue());

        // Create an instance for 6/7 using the third constructor
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine("\nFraction 3 (using third constructor):");
        fraction3.Display();
        Console.WriteLine("Value: " + fraction3.GetValue());

        // Create and display custom fractions
        // Create an instance for 3/4
        Fraction fraction4 = new Fraction(3, 4);
        Console.WriteLine("\nFraction 4 (3/4):");
        Console.WriteLine("Fraction String: " + fraction4.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction4.GetDecimalValue());

        // Create an instance for 1/3
        Fraction fraction5 = new Fraction(1, 3);
        Console.WriteLine("\nFraction 5 (1/3):");
        Console.WriteLine("Fraction String: " + fraction5.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction5.GetDecimalValue());
    }
}