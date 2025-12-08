/*
Arrays of References
Imagine we wanted to Flip() each object from a group of Encyclopedia and Novel types:

Novel nov1 = new Novel();
Novel nov2 = new Novel();
Encyclopedia enc1 = new Encyclopedia();
Encyclopedia enc2 = new Encyclopedia();
nov1.Flip();
nov2.Flip();
enc1.Flip();
enc2.Flip();

Copy to Clipboard

The preceding code works, but it would be faster and safer to store the references in an array and loop through them. But would it be an array of Novel[], an array of Encyclopedia[], or something else?

We can create references to Encyclopedias and Novels as IFlippables. Instead of dealing with individual 
variables
Preview: Docs Variables are used to store and manipulate data. In C#, each variable has a type that determines the values it can store.
, we can use an array of IFlippable references:

IFlippable[] flippables = new IFlippable[] { new Novel(), new Novel(), new Encyclopedia(), new Encyclopedia()};

Copy to Clipboard

To Flip() each element, we can write a foreach loop:

foreach (IFlippable f in flippables)
{
  f.Flip();
}

Copy to Clipboard

We can only access the functionality defined in the interface. For example, we couldn’t access f.Title because Title isn’t a property defined in IFlippable.
*/


using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Encyclopedia enc1 = new Encyclopedia(32, "Encyclopedia Britannica", "Encyclopedia Britannica");
			Encyclopedia enc2 = new Encyclopedia(19, "Codecademy Curriculum Team", "Codecademy Encyclopedia of Coding Knowledge");
			Novel nov1 = new Novel(48, "Jane Austen", "Pride and Prejudice");
			Novel nov2 = new Novel(23, "Charles Dickens");
			
      Book [] books = new Book[] {enc1, enc2, nov1, nov2};

      foreach (Book book in books)
      {
        Console.WriteLine(book.Title); 
      }


    }
  }
}

