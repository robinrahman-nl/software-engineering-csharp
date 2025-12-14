/*
LINQ with Other Collections
You’ve mostly seen LINQ used with 
arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
, but it can be used for 
lists
Preview: Docs A List in C# is a dynamic data structure that stores multiple objects of a specified type.
 as well! The syntax is the same:

List<string> heroesList = new List<string> { "Zoe", "Dorian", "Marlena" };

var longLoudheroes = from h in heroesList
  where h.Length >= 7
  select h.ToUpper();

// longLoudHeroes is [ "MARLENA" ]

Copy to Clipboard

Technically, LINQ can be used with any type that supports foreach 
loops
Preview: Docs Loading link description
, but we won’t cover all of those here.
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

      // 1. 
      // Query heroesList to find all hero names that contain either a v or y.
      var heroesWithVOrY = heroesList.Where(h => h.Contains('v') || h.Contains('y'));

      foreach (var item in heroesWithVOrY)
      {
        Console.WriteLine(item);
      }

        


      
    }
  }
}
