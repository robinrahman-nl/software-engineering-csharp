/*
Static Classes
We’ve covered a few static members, including fields, properties, 
methods
Preview: Docs Loading link description
, and constructors. C# also allows us to create entire static classes!

static class Utility {
  public static void Useful() {
    Console.WriteLine("This is a useful method");
  }
}

Copy to Clipboard

A static class cannot be instantiated and may only contain static members, so we should only create one if we are making a utility or library, like Math or Console.

These two common 
classes
Preview: Docs A blueprint or template for creating objects.
 are static because they are just tools — they don’t need specific instances:

Math.Min(34, 54);
Console.WriteLine("Hello, world!");
Utility.Useful();
*/

using System;

namespace StaticClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. 
      // We rarely create static classes of our own, so let’s practice using other static classes. 
      // First, print the value of pi (a commonly-used value in geometry) which is stored in Math.PI.

      Console.WriteLine(Math.PI);
      Console.WriteLine(Math.Abs(-32));
    }
  }
}
