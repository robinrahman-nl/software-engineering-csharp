// See https://aka.ms/new-console-template for more information

/*
Looping through Lists
Like 
arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
, we can perform an operation for every element in the list using for and foreach 
loops
Preview: Docs Loading link description
.

With for loops, make sure to use Count to stay within the bounds of the list.

for (int i = 0; i < numbers.Count; i++)
{
   Console.WriteLine(numbers[i]);
}

Copy to Clipboard

With a foreach loop, the counting is handled for us:

foreach (int number in numbers)
{
   Console.WriteLine(number);
}

Copy to Clipboard

Generally, we prefer foreach loops because they require less typing and less chance for typos.

If the index is used in the operation, like printing out each index and element together, then we’ll use for loops.
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    { 
      List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
      Random rand = new Random();
      
      Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
      // First loop
      for (int i = 0; i < runners.Count; i++)
      {
        Console.WriteLine($"{i+1}: {runners[i]}");
      }
      
      Console.WriteLine("\nPrinting runner bibs...");
      
      // Second loop
      foreach (string runner in runners)
      {
        string name = runner.ToUpper();
        int id = rand.Next(100, 1000);
        Console.WriteLine($"{id} - {name}");
      }

    }
  }
}