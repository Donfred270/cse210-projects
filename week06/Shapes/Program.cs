// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test Square
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Test Rectangle
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Test Circle
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Yellow", 7));
        shapes.Add(new Rectangle("Purple", 3, 9));
        shapes.Add(new Circle("Orange", 4.5));

        // Iterate through the list and display color and area
        Console.WriteLine("\nProcessing shapes in the list:");
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            // For Circle, format to 2 decimal places
            string areaDisplay = shape is Circle ? $"{area:F2}" : $"{area}";
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {areaDisplay}");
        }
    }
}