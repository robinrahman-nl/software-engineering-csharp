/*
Introduction to Polymorphism
Imagine a method that changes its behavior based on the object it works with. In object-oriented programming, Polymorphism allows 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
with the same name to perform different actions depending on the object.

Consider an Animal class with subclasses like Dog, Cat, and Bird. Polymorphism lets you call the same method, such as MakeSound(), on any of these objects and get different results based on the subclass.

Without polymorphism, you’d need to check each Animal subclass type and call the appropriate method, leading to repetitive and cluttered code. Instead, polymorphism lets you call MakeSound(), automatically invoking the correct method based on the object’s type. This makes your code cleaner, more concise, and easier to maintain, allowing new animal types to be added without modifying existing code.

Polymorphism provides several benefits:

Flexibility and Maintainability: You can add new []
classes
Preview: Docs A blueprint or template for creating objects.
with little or no modification to the existing code.
Code Reusability: Common functionality can be written in the base class, and specific functionality can be implemented in derived classes.
Simplified Code: Complex switch-case or if-else structures can be avoided, making the code cleaner and easier to read.
Instructions
The code editor showcases Polymorphism in action. Take a look at the code and move to the next exercise when you are ready to learn how to implement Polymorphism within your class structure.
*/


using System;

namespace PolymorphismBasics
{
  class Animal
  {
    public virtual void MakeSound()
    {
      Console.WriteLine("Animal makes a sound.");
    }
  }

  class Dog : Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Dog barks.");
    }
  }

  // Define the Cat class here
  class Cat : Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Cat meows.");
    }
  }


  public class Program
  {
    static void Main(string[] args)
    {
      // Create instances of derived classes
      Animal myDog = new Dog();
      Animal myCat = new Cat();

      // Call the MakeSound method
      myDog.MakeSound(); // Output: Dog barks.
      myCat.MakeSound(); // Output: Cat meows.
    }
  }
}