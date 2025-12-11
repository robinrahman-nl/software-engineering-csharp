/*
Importing LINQ
Before we jump into the syntax and 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
, let’s import the features into our code. To use LINQ in a file, add this line to the top:

using System.Linq;

Copy to Clipboard

Often times we use LINQ with generic collections (like lists), so you may see both namespaces imported into a file:

using System.Collections.Generic;
using System.Linq;


*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
  
      var shortHeroes = from h in heroes
                        where h.Length < 5
                        select h;

      // Printing...
      Console.WriteLine("Your short heroes are...");
      
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }
    }
  }
}
