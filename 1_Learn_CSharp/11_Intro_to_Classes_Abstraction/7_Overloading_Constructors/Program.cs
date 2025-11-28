/*
Overloading Constructors
Just like other 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
, constructors can be overloaded. For example, the following Book class has 2 constructor methods defined — one that takes 2 arguments and another that takes only 1:

public class Book
{
  public string title;
  public string author;

  public Book(string title, string author)
  {
    this.title = title;
    this.author = author;
  }

  public Book(string title)
  {
    this.title = title;
    this.author = "Unknown";
  }
}

Copy to Clipboard

The first constructor sets values for both fields, and the second provides a default value for when the author is not specified. We can create Book instances in two ways:

Book b1 = new Book("1984", "George Orwell");
Book b2 = new Book("Untitled");

Copy to Clipboard

Note that there is duplicated code between the 2 constructors (this.title = title;). To avoid this redundancy, we have two options:

Use Default Arguments:

public Book(string title, string author = "Unknown")
{
  this.title = title;
  this.author = author;
}

Copy to Clipboard

Use : this() to refer to another constructor in the same class. This is useful when the second constructor has additional functionality:

public Book(string title, string author)
{
  this.title = title;
  this.author = author;
}

public Book(string title) : this(title, "Unknown")
{
  Console.WriteLine("Author not specified. Value defaulted to 'Unknown'.");
}

Copy to Clipboard

Remember, this.title refers to the current instance. Using this() like a method refers to another constructor in the current class. Here, the second constructor calls the first and prints additional information to the console.
*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace OverloadingConstructors
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      f.trees = 100;
      Console.WriteLine(f);


      Forest f2 = new Forest("Congo");
      Console.WriteLine(f2);

      // 2. call the second constructor to create a Forest object named "Rendlesham".
      Forest Rendlesham = new Forest("Rendlesham");

      // 3. print the biome field of this new instance.
      Console.WriteLine(Rendlesham.biome); // Unknown
      
      Console.WriteLine(Rendlesham);
    }
  }
}
