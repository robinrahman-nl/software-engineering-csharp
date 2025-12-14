/*
Basic Method Syntax: Select
To transform each element in a sequence — like writing them in uppercase — we can use the select operator. In method syntax, it’s written as the method Select(), which takes a lambda expression:

string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
var loudHeroes = heroes.Select(h => h.ToUpper());

Copy to Clipboard

We can combine Select() with Where() in two ways:

Use separate statements:
var longHeroes = heroes.Where(h => h.Length >= 7);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

Copy to Clipboard

Chain the expressions:
var longLoudHeroes = heroes
  .Where(h => h.Length >= 7)
  .Select(h => h.ToUpper());

Copy to Clipboard

As with most of LINQ, the choice is up to you!

In the first option, we use two variable names and two statements. You can tell there are two separate statements by counting the semicolons.

In the second option, we use one variable name and one statement.

If we must use method syntax, we prefer the second option (chaining) because it is easier to read and write. You can imagine each line like a step in a conveyor belt, filtering and transforming the sequence as it goes.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    { // 1. 
      // Write a method syntax query that:
      // selects all of the elements in heroes containing the character "r" and
      // transforms them to lowercase
      // Use separate statements and store the final result in a variable lowerHeroesWithR.
      string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
      
      var heroesWithR = heroes.Where(h => h.Contains('r'));
      var lowerHeroesWithR = heroesWithR.Select(h => h.ToLower());

      // print
      foreach (var item in lowerHeroesWithR)
      {
        Console.WriteLine(item);
      }

// 2. 
// Write a second query that does the same thing but uses chained expressions.
// Store the result in a variable named sameResult.
var sameResult = heroes.Where(h => h.Contains('r')).Select(h => h.ToLower());

// print
foreach (var item in sameResult)
{
  Console.WriteLine(item);
}


    }
  }
}
