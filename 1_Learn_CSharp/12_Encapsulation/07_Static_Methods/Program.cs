/*
Static Methods
Fields and properties are not the only members that can be made static — we can also create static 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 to define behavior that applies to a class rather than its instances:

class Book
{
  // Non-static
  public string Title 
  { get; set; }

  private static string Definition { get; set; } = "A connected collection of pages";
  public static void Define()
  {
    Console.WriteLine(Definition);
  }
}

Copy to Clipboard

Like other static members, static methods are called from the class rather than an instance:

public static void Main(string[] args)
{
  Book.Define();
  // Prints "A connected collection of pages"
}

Copy to Clipboard

Static methods can only access other static members. They cannot access instance members:

class Book
{
  // Non-static
  public string Title 
  { get; set; }

  private static string Definition { get; set; } = "A connected collection of pages";
  public static void Define()
  {
    // OK. Static methods can access static properties
    Console.WriteLine(Definition);

    // Throw an error, static method cannot access instance properties
    Console.WriteLine(Title);
  }
}

Copy to Clipboard

The preceding code would throw an error like this:

error CS0120: An object reference is required for the non-static field, method, or property 'Book.Title'

*/

using System;

namespace StaticMethods
{
  class Program
  {
    static void Main(string[] args)
    {



      
      // ########################################################################
      Forest printForest = new Forest("Amazon");

      Forest.PrintForestFacts();   // Works  (because static method are associated woth clas itself)
      // printForest.PrintForestFacts();  // Error ( cause static methods cannot be associated with a instance)

      Console.WriteLine($"########################################################################\n{printForest}\n########################################################################");

    }
  }
}
