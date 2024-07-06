using System;

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

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Move(); // Output: Car is moving
        
        Bicycle myBicycle = new Bicycle();
        myBicycle.Move(); // Output: Bicycle is moving
    }
}
