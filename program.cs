
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

// Part 3: Interfaces

// Interface
interface IMovable
{
    void Move();
}

// Class Car implementing IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class Bicycle implementing IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Part 1: Inheritance and Method Overriding
        
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound(); // Output: Some generic sound
        
        Dog myDog = new Dog();
        myDog.MakeSound(); // Output: Bark
        
        Cat myCat = new Cat();
        myCat.MakeSound(); // Output: Meow
        
        Console.WriteLine();

        // Part 2: Abstract Classes and Methods
        
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of Circle: {circle.GetArea()}"); // Output: Area of Circle: 78.53981633974483
        
        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Output: Area of Rectangle: 24
        
        Console.WriteLine();

        // Part 3: Interfaces
        
        Car myCar = new Car();
        myCar.Move(); // Output: Car is moving
        
        Bicycle myBicycle = new Bicycle();
        myBicycle.Move(); // Output: Bicycle is moving
    }
}