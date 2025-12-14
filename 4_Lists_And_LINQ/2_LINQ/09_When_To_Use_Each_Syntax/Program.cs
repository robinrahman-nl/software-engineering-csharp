/*
When To Use Each Syntax
So far you’ve seen query syntax and two flavors of method syntax.

// Query syntax
var longLoudheroes = from h in heroes
  where h.Length >= 7
  select h.ToUpper();

// Method syntax - separate statements
var longHeroes = heroes.Where(h => h.Length >= 7);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

// Method syntax - chained expressions
var longLoudHeroes2 = heroes
  .Where(h => h.Length >= 7)
  .Select(h => h.ToUpper());

Copy to Clipboard

As you get into more advanced LINQ queries and learn new 
operators
Preview: Docs Loading link description
, you’ll get a feel for what works best in each situation. For now, we generally follow these rules:

For single-operator queries, use the method syntax.
For everything else, use the query syntax.
*/



// follow these rules:
// For single-operator queries, use the method syntax.
// For everything else, use the query syntax.

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
    class Program
    {
        // 1. Write a method syntax query that transforms each element in heroes to this format:
        // Introducing...[hero's name]!
        static void Main()
        {
            string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

            var introduceHeroes = heroes.Select(h => $"Introducing ... {h}!");
            // print 
            foreach (var item in introduceHeroes)
            {
                Console.WriteLine(item);
            }

            // 2. 
            // Write a query syntax query that selects elements containing the character "i" and returns the index of the character in each element. 
            // For example, instead of "Liam", the result should contain 1.
            var herosWith1 = from h in heroes
            where h.Contains('i')
            select h.IndexOf('i');

            // print
            foreach (var item in herosWith1)
            {
                Console.WriteLine(item); // 1 3
            }






        }
    }
}
