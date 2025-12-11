/*
Var
Every LINQ query returns either a single value or an object of type IEnumerable<T>. For now, all you need to know about that second type is that:

It works with foreach loops, just like arrays and lists.
You can check its length with Count().
Since the single value type and/or the parameter type T is not always known, it’s common to store a query’s returned value in a variable of type var.

var is just an implicitly typed variable — we let the C# compiler determine the actual type for us. Here’s one example:

string[] names = { "Tiana", "Dwayne", "Helena" };
var shortNames = names.Where(n => n.Length < 4);

Copy to Clipboard

In this case, shortNames is actually of type IEnumerable<string>, but we don’t need to worry ourselves about that as long as we have var!
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LearnLinq
{
    class Program
    {
        static void Main()
        {
            // 1. 
            // Let’s practice using var with LINQ.
            // Create a variable of type var named shortHeroes and set it equal to this LINQ query:
            // from h in heroes
            // where h.Length < 7
            // select h;
            List<string> heroes = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
            var shortHeroes = from h in heroes
                              where h.Length < 7
                              select h;

            // 2. 
            //  Use a foreach loop to print out each element in shortHeroes.
            foreach (var item in shortHeroes)
            {
                Console.WriteLine(item);
            }

            // 3. 
            // Create another variable of type var named longHeroes and set it equal to this LINQ query:
            // heroes.Where(n => n.Length >= 7);
            var longHeroes = heroes.Where(n => n.Length >= 7);

            // 4. 
            // Use Count() to print the number of elements in longHeroes.
            Console.WriteLine(longHeroes.Count());
        }
    }
}
