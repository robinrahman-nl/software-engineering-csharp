/*
Methods
Another type of class member is 
methods
Preview: Docs Loading link description
.

Methods organize code to perform tasks and define how class instances behave. They represent the actions an object can perform.

The following code defines a Shape class with 1 field, area, and 1 method, IncreaseArea():

class Shape {
  public int area;
  public void IncreaseArea(int amount)
  {
    area += amount;
  }
}

Copy to Clipboard

Here, IncreaseArea() changes the value of the area field for the instance of Shape that it is called on. We can call the method like this:

Shape s = new Shape();
s.IncreaseArea(2);
Console.WriteLine(s.area); // Prints 2

Copy to Clipboard

Remember, since we declared area without an initial value, it will default to 0 for each instance that is created.
*/

using System;

namespace Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.biome = "Tropical";
      
      Console.WriteLine(f.name);
    }
  }
}
