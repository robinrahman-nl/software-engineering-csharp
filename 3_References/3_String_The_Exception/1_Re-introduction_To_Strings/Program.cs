/*
Re-introduction to Strings
Previous lessons have stated that all 
classes
Preview: Docs A blueprint or template for creating objects.
 are reference types and all “primitive” values are value types.

// Reference type
Object o = new Object();
// Value type
bool b = true;

Copy to Clipboard

Do we consider string a reference type or a value type?

Spoiler! 
Strings
Preview: Docs Loading link description
 are technically reference types. But in action, it’s a bit more complicated. Nearly every C# program uses some strings, so you’ll need to know how they work. This lesson will explain the unique behavior of string references.

Note: in C#, String and string are equivalent. This just gives us more options when we are coding. It’s convenient for beginners because string is typically introduced with other primitive value types like int and bool.

Instructions
Look at Program.cs. Can you explain all of this code in terms of references and values?
*/

using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      // Example 1
      string dog = "chihuahua";
      string tinyDog = dog;
      dog = "dalmation";
      Console.WriteLine(dog);
      // Output: "dalmation"
      Console.WriteLine(tinyDog);
      // Output: "chihuahua"

      // Example 2
      string s1 = "Hello ";
      string s2 = s1;
      s1 += "World";
      System.Console.WriteLine(s1);
      // Output: "Hello World"
      System.Console.WriteLine(s2);
      // Output: "Hello "
    }
  }
}
