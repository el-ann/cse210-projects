using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Purple", 3),
            new Rectangle("Orange", 2, 5),
            new Circle("Turqoise", 4)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.Color} shape has an area of {shape.GetArea()}.");
        }
    }
}
