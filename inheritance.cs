using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound(); // Output: Some generic sound
        
        Dog myDog = new Dog();
        myDog.MakeSound(); // Output: Bark
        
        Cat myCat = new Cat();
        myCat.MakeSound(); // Output: Meow
    }
}
