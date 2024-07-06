using System;

// Abstract class
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of Circle: {circle.GetArea()}"); // Output: Area of Circle: 78.53981633974483
        
        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Output: Area of Rectangle: 24
    }
}

