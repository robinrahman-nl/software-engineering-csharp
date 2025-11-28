/*
Inheritance
Introduction to Inheritance
Duplicated code leads to errors. Say you have two 
classes
Preview: Docs Loading link description
 Sedan and Truck. They’re different types, but they share a few properties and 
methods
Preview: Docs Loading link description
, like SpeedUp() and SlowDown(). If one of those members (say it’s SpeedUp()) has to change, then we would have to change the code in every location where SpeedUp() is defined.

In this case, it’s two classes, but in other programs, it may be many more! Imagine having 10 different classes that have a similar member, SpeedUp(), and needing to go through each of those classes every time the method needs to be modified. There are two reasons we don’t want to make the same change on code across multiple files:

it is more time-consuming
more importantly, it is a big risk of making mistakes
In this lesson, we learn about a solution to this problem: 
inheritance
Preview: Docs Loading link description
. With inheritance, you can define one superclass that contains the shared members (like SpeedUp() and SlowDown()). All classes that need those members can then inherit them from the superclass.
*/

// Check out Sedan.cs and Truck.cs. What code is duplicated across these types?

using System;

namespace LearnInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
      s.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s.Speed}");

      Sedan s2 = new Sedan(70);
      Console.WriteLine($"Sedan with license plate {s2.LicensePlate} and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
      s2.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s2.Speed}");
      
      Truck t = new Truck(45, 500);
      Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
      t.SpeedUp();
      Console.WriteLine($"Truck's faster speed: {t.Speed}");
    }
  }
}