/*
Static Fields and Properties
We’ve learned to make instances of a class and model each instance’s state and behavior using class members, such as fields and 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
. But what if we need to do something related to the type itself, not its instances?

Static members are members that are associated with the class itself. They are defined using the static keyword, which should follow the access modifier if one is present. Let’s start by exploring static fields and properties:

class Book
{
  // Instance property
  public string Title
  { get; set; }

  // Static property
  public static string Definition { get; set; } =  "A connected collection of pages";
}

Copy to Clipboard

In the preceding code sample, we define two properties for the Book class. Title is a non-static property, so any instances of the Book class we create will each have its own Title property.

Definition is a static property associated with the Book class. Within the class definition, static members can be referenced by their name alone, or using the class name and dot (.) notation. Outside the class definition, we must access static members using the class name and dot (.) notation. Note that we do not need to make an instance of Book to access its static member:

static void Main(string[] args)
{
  // Outside the Book class, we must access Definition using the class name and dot notation
  Console.WriteLine(Book.Definition);
  // Prints "A connected collection of pages"
}

Copy to Clipboard

Since Definition is an auto-implemented static property, the backing private field that is created automatically will also be static. If the related field and property are defined separately, they must match in being static or non-static.

If we tried to access a static member from an instance:

static void Main(string[] args)
{
  Book novel = new Book();
  novel.Title = "Yesterday and Tomorrow"; // OK. Title is an instance property
  Console.WriteLine(novel.Definition); // Would cause an error since Definition is static
}

Copy to Clipboard

We would get an error like:

error CS0176: Static member 'Book.Definition' cannot be accessed with an instance reference, qualify it with a type name instead
*/


using System;

namespace StaticFields
{
  class Program
  {
    static void Main(string[] args)

    {
      Forest printForest = new Forest("Amazon");

        Console.WriteLine(Forest.ForestsCreated); // Works. Accessing ForestsCreated with succes. 
      // Console.WriteLine(printForest.ForestsCreated);  // error CS0176: Member 'Forest.ForestsCreated' cannot be accessed with an instance reference; qualify it with a type name instead

      // ########################################################################
      Console.WriteLine($"########################################################################\n{printForest}\n########################################################################");

      
    }
  }
}
