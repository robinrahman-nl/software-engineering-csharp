/*

Basic Query Syntax
A basic LINQ query, in query syntax, has three parts:

string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

var shortHeroes = from h in heroes
  where h.Length < 7
  select h;

Copy to Clipboard

The from operator declares a variable to iterate through the sequence. In this case, h is used to iterate through heroes.
The where operator picks elements from the sequence if they satisfy the given condition. The condition is normally written like the conditional expressions you would find in an if statement. In this case, the condition is h.Length < 7.
The select operator determines what is returned for each element in the sequence. In this case, it’s just the element itself.
The from and select 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
 are required, where is optional. In this next example, select is used to make a new string starting with “Hero: “ for each element:

var heroTitles = from hero in heroes
  select $"HERO: {hero.ToUpper()}";

Copy to Clipboard

Each element in heroTitles would look like "HERO: ZOE", "HERO: LIAM", etc.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    // 1. Write a from - where - select query that selects all of the elements in heroes that contain the character "i". 
    // Store the result in a variable named heroesWithI.
    static void Main()
    {
      string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
      var heroesWithI = from h in heroes where h.Contains('i') select h;

      // 2. 
      // Write a from - select query that returns the same array as heroes, 
      // but every character "a" is replaced with an underscore (_). 
      // Store the result in a variable named underscored.

      var underscored = from h in heroes select h.Replace('a', '_');

      // print
      foreach (var item in underscored)
      {
        Console.WriteLine(item);
      }
    }
  }
}
