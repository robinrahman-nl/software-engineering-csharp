/*
Auto-Implemented Properties
The basic getter and setter pattern is so common that there’s a shorthand called an auto-implemented property (sometimes also called an “automatic property”). This allows us to write more concise and readable code. As a reminder, here’s the basic pattern for a property:

private string size;
public string Size
{
  get { return size; }
  set { size = value; }
}

Copy to Clipboard

This pattern can be written as an auto-implemented property like so:

public string Size
{ get; set; }

Copy to Clipboard

In this form, we don’t have to write out the get() and set() 
methods
Preview: Docs Loading link description
 or define a private size field. The field is automatically created in the background, so we only need to deal with the Size property.
*/

using System;

namespace AutoImplementedProperties
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Tropical";
      
      Console.WriteLine(f.Name);
    }
  }
}
