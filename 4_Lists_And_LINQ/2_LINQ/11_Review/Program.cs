/*
Review
Great job — we just covered a lot of LINQ! Here’s a recap:

LINQ is a set of language and framework features for writing structured, type-safe queries over local object collections and remote data sources.
Use LINQ by referencing the System.Linq namespace in your file.
When a LINQ query returns a sequence of elements its type is IEnumerable<T>. That means it works with foreach loops, and its length is accessible with Count().
Store a query’s result in a variable of type var. var is an implicit type, meaning it gets all of the benefits of type-checking without our specifying the actual type.
LINQ queries can be written in method syntax or query syntax.
We prefer method syntax for single operations and query syntax for almost everything else.
The Where operator is used to select certain elements from a sequence.
The Select operator determines what is returned for each element in the sequence.
The from operator declares a range variable that is used to traverse the sequence.
LINQ can be used on arrays and lists, among other data types.

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
      List<string> heroesList = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
      
      // Query syntax
      var queryResult = from h in heroesList
        where h.Contains("a")
        select $"{h} contains an 'a'";
     
      // Printing...
      Console.WriteLine($"queryResult has {queryResult.Count()} elements");
      
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }    
    }
  }
}
