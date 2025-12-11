/*
Overriding Object Members
The Equals() and ToString() 
methods
Preview: Docs Loading link description
 in Object are virtual, so they can be overridden.

For example, we can override ToString() in the Novel class:

class Novel
{
  * Other members omitted *

  public override string ToString()
  {
    return $"This Novel is currently on page {CurrentPage}."; 
  }
}

Copy to Clipboard

Now any Novel instance will use this version of the method:

*/

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");

      //  call bk.ToString() method and print the result.
      Console.WriteLine(bk.ToString());
    }
  }
}
