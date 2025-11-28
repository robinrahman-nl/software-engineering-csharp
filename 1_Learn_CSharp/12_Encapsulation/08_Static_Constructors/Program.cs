/*
Static Constructors
An instance constructor is run each time a new instance of a class is created and typically handles setting values for instance fields and properties.

We can use a static constructor to handle setup for a class that only needs to be run once before the class is used. Typically, we use static constructors to set values for static fields and properties.

The static constructor of a class will only ever run once during the execution of a program, the first time either one of these events occurs:

an object is made from the type
another static member of the class is accessed
class Book
{
  public string Title 
  { get; set; }

  private static string Definition { get; set; } 

  static Book()
  { 
    Definition = "A connected collection of pages";
  }

  public static void Define()
  {
    Console.WriteLine(Definition);
  }
}

Copy to Clipboard

The preceding code sample defines a Book class with a static constructor, which sets the value of the static Definition property.

A static constructor cannot have an access modifier or take parameters. A class may only have one static constructor, meaning they also cannot be overloaded. Static constructors cannot be called directly — they are only ever called automatically under the conditions specified before.

Labeling a static constructor with private or public produces an error like:

error CS0515: 'Book.Book()': static constructor cannot have an access modifier
*/

using System;

namespace StaticConstructors
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest.PrintForestFacts();
    }
  }
}
