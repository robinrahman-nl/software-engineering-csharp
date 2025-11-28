/*
Constructors
In previous examples, we created new objects and set property values one by one.

C# has a special method type, called a constructor, that runs every time an object is created.

If no constructor is defined, C# provides a default parameterless constructor, allowing us to instantiate objects without errors:

Project blank = new Project();

Copy to Clipboard

A constructor looks like a method but lacks a return type and has the same name as its class. Constructors can take parameters, just like other 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
, and we can also add code within the constructor body to set instance values:

class Polygon
{
  public int sides;

  public Polygon(int sides)
  {
    this.sides = sides;
  }
}

Copy to Clipboard

This is where this is necessary! When a value that is passed into the constructor will be assigned directly to an instance variable, it is common practice to give the parameter and the instance variable the same name.

In this example, within the body of the constructor, the name sides refers to the value that is passed as an argument when the constructor function is called, NOT the instance variable. We must use this along with the instance variable in order to assign the argument’s value to the correct place.

Assigning sides = sides instead would rewrite the value of the parameter sides with its own argument’s value, leaving the instance variable sides with its default value, which is 0 for an int.

This constructor runs when we create a new object with the new keyword:

Polygon pentagon = new Polygon(5);
// pentagon.sides is 5

*/


using System;

namespace Constructors
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Forest f = new Forest("Congo", "Tropical");
    
      f.trees = 0;
    
      
      Console.WriteLine(f.name);   // Congo
      Console.WriteLine(f.biome);  // Forest
      Console.WriteLine(f);        // Constructors.Forest
      

    


    }
  }
}
