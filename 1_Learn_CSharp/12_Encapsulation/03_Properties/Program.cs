/*
Properties
Often, we need to specify what values for a given field are valid and invalid. C# provides a special class member for this: properties.

A property controls access to a field, allowing us to validate values before they are set. A property consists of two methods:

a get() method, or getter, called when the property is accessed
a set() method, or setter, called when the property is assigned a value
This is a basic Area property without validation:

public int area;
public int Area
{
  get { return area; }
  set { area = value; }
}

Copy to Clipboard

The Area property is associated with the area field. It’s common to name a property with the title-cased version of its field’s name, such as age and Age, or name and Name. Note that the get and set method definitions do NOT include a pair of parentheses following the method name.

The set() method uses the keyword value, representing the value assigned to the property. In Program.cs, accessing the Area property calls the get() and set() methods:

Shape s = new Shape();
s.Area = -1; // set() is called
Console.WriteLine(s.Area); // get() is called -- Prints -1
s.area = 2; // access area directly, sets area to 2

Copy to Clipboard

In this example, when set() is called, value is -1, so area is set to -1. Because area and Area are both set to public, both are accessible outside of the class definition. Typically, we set the field to private and the property to public in order to restrict access to only the property.

Here’s the same property with validation in the set() method and the field set as private. If we try to set Area to a negative value, it will be set to 0 instead. If we attempt to access the area field directly outside of the class, it will produce an error indicating that area is not accessible in the current context:

private int area;
public int Area
{
  get { return area; }
  set 
  { 
    if (value < 0) { area = 0; }
    else { area = value; }
  }
}

Copy to Clipboard

In Program.cs:

Shape s = new Shape();
s.Area = -1; // set() is called
Console.WriteLine(s.Area); // get() is called -- Prints 0
// s.area = 2; // would throw error CS0122, as area is not accessible here

*/

using System;

namespace Properties
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.Biome = "Tropical";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}
