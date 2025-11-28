/*
Get-Only Properties
We have learned how to use properties for field validation. By applying public or private, we can have greater control over field access.

For our Area property, if we want programs to be able to get the value, but not set it, we can do one of the following:

Omit the set() method.
Make the set() method private.
Example without set():

public string Area
{
  get { return area; }
}

Copy to Clipboard

Attempting to set Area results in:

error CS0200: Property or indexer 'Shape.Area' cannot be assigned to (it is read-only)

Copy to Clipboard

Example with private set():

public int Area
{
  get { return area; }
  private set { area = value; }  
}

Copy to Clipboard

Attempting to set Area in Main() results in:

error CS0272: The property or indexer 'Shape.Area' cannot be used in this context because the set accessor is inaccessible

Copy to Clipboard

Setting Area without including set() results in an error regardless of where it is accessed. When set() is private, we get an error only outside the Shape class.

Generally, we prefer a private set() because it allows other class 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 to set the property.
*/



using System;

namespace GetOnlyProperties
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.Biome = "Tropical";
      f.Age = 5;
      
    }
  }
}
