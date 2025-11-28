/*
Access Inherited Members with Base
To construct a Sedan, we must first construct an instance of its superclass Vehicle.

We can refer to a superclass inside a subclass with the base keyword.

For example, in Sedan:

base.SpeedUp();

Copy to Clipboard

refers to the SpeedUp() method in Vehicle.

There’s a special syntax for calling the superclass constructor:

class Sedan : Vehicle
{
  public Sedan (double speed) : base(speed)
  {
  }
}

Copy to Clipboard

The preceding code shows a Sedan that inherits from Vehicle. The Sedan constructor calls the Vehicle constructor with one argument, speed. This works as long as Vehicle has a constructor with one parameter of type double.

Even if we don’t use base() in Sedan, it will call a Vehicle constructor. Without an explicit call to base(), any subclass constructor will implicitly call the default parameterless constructor for its superclass. For example, this code implicitly calls Vehicle():

class Sedan : Vehicle
{
  // Implicitly calls base(), aka Vehicle()
  public Sedan (double speed)
  {
  }
}

Copy to Clipboard

The preceding code is equivalent to this:

{
  public Sedan (double speed) : base()
  {
  }
}

Copy to Clipboard

This code will only work if the constructor Vehicle() exists. If it doesn’t, then an error will be thrown.
*/

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