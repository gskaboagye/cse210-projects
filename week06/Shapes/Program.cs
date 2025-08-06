using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shapes Project!");

        List<Shape> shapes = new List<Shape>
        {
            new Circle("Red", 5.0),
            new Rectangle("Blue", 4.0, 6.0),
            new Square("Green", 4.0)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():0.00}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
