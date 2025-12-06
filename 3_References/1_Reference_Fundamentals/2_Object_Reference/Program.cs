/*
Introduction to References
What do you think will be printed by this code?

Encyclopedia enc1 = new Encyclopedia();
Encyclopedia enc2 = enc1;
enc1.CurrentPage = 0;
enc2.CurrentPage = 16;
Console.WriteLine(enc1.CurrentPage);
Console.WriteLine(enc2.CurrentPage);

Copy to Clipboard

The answer is 16 and 16.

To understand what’s happening here, we must understand references. References are going to change the way we can modify and store values. This lesson will explore how references work in C# and how they are useful.

Instructions
This lesson uses the Book, Encyclopedia, and Novel classes and the IFlippable interface. To get acquainted, select the drop-down arrow for each file.

IFlippable is an interface with 2 members:
Book is the base class, with the following members:
Encyclopedia and Novel are classes that extend the base class and implement the interface.

Encyclopedia has the following members:
And Novel has the following members
*/

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Encyclopedia enc1 = new Encyclopedia();
      Encyclopedia enc2 = enc1;
      enc1.CurrentPage = 0;
      enc2.CurrentPage = 16;
      Console.WriteLine(enc1.CurrentPage);
      Console.WriteLine(enc2.CurrentPage);

      // 1. Create a new Novel object with a current page of 5 using the constructor new Novel(5). 
      // Store a reference to that object and name it nov1. Its type should also be Novel.
      new Novel(5);
      Novel nov1 = new Novel(5);
      
      // 2. Create another reference to that object and name it nov2.
      Novel nov2 = nov1;

      // 3. Flip nov2 by calling its Flip() method. This increments the CurrentPage property by 1.
      nov2.Flip();

      // 4. Print out the CurrentPage property for both nov1 and nov2. They should be the same!
      Console.WriteLine(nov1.CurrentPage); // 6
      Console.WriteLine(nov2.CurrentPage); // 6


     






    }
  }
}
