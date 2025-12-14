/*
Method and Query Syntax
In LINQ, you can write queries in two ways: in query syntax and method syntax.

Query syntax looks like a multi-line sentence. If you’ve used SQL, you might see some similarities:

var longLoudHeroes = from h in heroes
  where h.Length >= 7
  select h.ToUpper();

Copy to Clipboard

Method syntax looks like plain old C#. We make method calls on the collection we are querying:

var longHeroes = heroes.Where(h => h.Length >= 7);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

Copy to Clipboard

In LINQ, we see where/Where() and select/Select() show up as both keywords and method calls. To cover both cases, they’re generally called 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
.

Note: the capitalization of the keyword is dependent on which type of syntax we use. With query syntax, the query keywords must be all lowercase. For method syntax, the 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 begin with a capital letter.

Every developer has a personal preference between syntaxes, but you should be able to read both. In this lesson, we’ll start with query syntax and then move on to method.
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
      // 1. 
      // Read the two queries in Program.cs. Each one returns a sequence of phrases, 
      // one for each hero name that contains an ‘a’. Run the code to see the output.

      // The queries return the same output, but they are written with different syntax. 
      // Which seems easier to read to you?
      string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

      // Query syntax
      var queryResult = from x in heroes
                        where x.Contains("a")
                        select $"{x} contains an 'a'";

      // Method syntax
      var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");

      // Printing...
      Console.WriteLine("queryResult:");
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }

      Console.WriteLine("\nmethodResult:");
      foreach (string s in methodResult)
      {
        Console.WriteLine(s);
      }
    }
  }
}
