// See https://aka.ms/new-console-template for more information

/*
Defining Methods
Up until now, we’ve been calling 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 that are provided by the C# language. Sometimes we will want to define custom methods for our programs.

The basic structure of a method definition looks like this:

static void OurMethodName()
{
}

Copy to Clipboard

We’ll skip over static and void for the moment.

In C#, it’s a convention to use PascalCase to name our methods. The name starts with an uppercase letter and each word following begins with an uppercase as well. It’s not required in C#, but it makes our code easier to read for other developers.

The body of our method goes between the curly braces: { }.

static void OurMethodName()
{
  Console.WriteLine("Hi there!");
}

Copy to Clipboard

The code in the body is executed whenever the method is called. Like any other method, we call it with parentheses.

OurMethodName();

Copy to Clipboard

We have already defined a method in each program we’ve written, Main() is a method. Every time we run code, the Main() method is executed.
*/

using System;

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
    }
    static void VisitPlanets()
    {
      Console.WriteLine("You visited many new planets…");
    }
    
  }
}
