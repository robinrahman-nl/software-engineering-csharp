/*
Introduction to Interfaces
Since programming is complex, it’s easy to make mistakes. For example, if we try to use an int like a string, it would cause a type error. C# has rules built-in that check for those mistakes before we use that code in the real world.

The following diagram estimates the number of bugs in our code at each stage of development. We discover and fix some of those bugs at each stage, so the number decreases from left to right. Sadly, we can’t fix every bug, but if we can catch bugs earlier, we save ourselves work and reduce user frustration.

We say that C# is “type-safe” because it helps us catch bugs at one of the earliest stages: the type-checking stage.

Stages of Product Lifecyle plotted against Expected Number of bugs. Stages of Product Lifecycle include Planning, Type Checking, Running Code, Peer Review, and User Feedback. The stages are plotted from left to right, with the number of bugs decreasing with each stage. "Type Checking" is highlighted, as this is an area where C# excels

The difference between an int and a string is clear, but what about custom-defined classes? Say we made Fruit and Vegetable types. Can we use PlantSeed() on both? Do they both have a Seed property? The computer running the program needs more information.

In this lesson we’ll dive into 
interfaces
Preview: Docs An interface is an abstract contract that defines methods and properties that must be implemented by any class that implements the interface.
, which are sets of actions and values that describe how a class can be used. This lets the computer check that we are using each type legally, thus preventing a whole group of type errors before we ever run our code!

In this lesson we’ll learn how to:

build our own interface
write 
classes
Preview: Docs Loading link description
 that implement an interface
combine class 
inheritance
Preview: Docs Loading link description
 an interface to create more complex systems
Instructions
Based on the code in Program.cs, we can expect the Sedan class to have:

a Speed property
a LicensePlate property
a Wheels property
a Honk() method
By the end of this lesson, you’ll build an interface that guarante
*/

using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
      s.Honk();
    }
  }
}
