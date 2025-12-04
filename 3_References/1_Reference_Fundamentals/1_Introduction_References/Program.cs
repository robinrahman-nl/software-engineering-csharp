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
    }
  }
}
