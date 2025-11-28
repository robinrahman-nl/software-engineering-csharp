// See https://aka.ms/new-console-template for more information

/*
Generic Collections
The list class is in a group of generic collections. They don’t exist in the default set of System classes, so we need to reference them with this line.

Generic collections are data structures that are defined with a generic type. Each class is defined generally without a specific type in mind. When we make an actual instance, we define the specific type:

List<string> citiesList = new List<string>();
List<Object> objects = new List<Object>();

Copy to Clipboard

In the same way, we can use Add() and Remove() without knowing a list’s data type.

For this reason, the formal class name of lists is List<T>. That T is a type parameter representing some type that we can specify later.
*/

using System;

// 1.
// Add a reference to the System.Collections.Generic namespace.
using System.Collections.Generic;  // 


namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      // 2. Declare three empty lists:
      // one should hold bool types
      List<bool> boolList = new List<bool>();

      // one should hold Random types
      List<Random> Rand = new List<Random>();

      // one should hold IServiceProvider types ( !! That’s right, interfaces work here too!! )
      List<IServiceProvider> serviceProvider = new List<IServiceProvider>();

      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      citiesList.Add("Rotterdam");

      foreach( string city in citiesList)
            {
                Console.WriteLine(city);
            }

    }
  }
}


// Review
/*
Review
In this lesson, we learned:

A list, or List<T>, is a generic, sequential data structure. The specific type that it contains is specified upon instantiation.
Lists are effectively unlimited.
List values can be accessed by index using square brackets: [ ].
To create an empty list, use a basic constructor. To create a list with values, use object initialization.
Add() adds an element to a list.
Remove() removes an element from the list. It returns true if it is successful and false otherwise.
Count is the number of elements in the array.
Contains() returns true if the argument exists in the list, false otherwise.
A sequence within a list is called a range. There are specific methods for working with ranges, including GetRange(), AddRange(), InsertRange(), and RemoveRange().
Lists are a type of generic collection, defined with generic type parameters. The type parameters are specified when instantiating any generic class.
Use lists and dictionaries in your code by including this line at the top of your file:
using System.Collections.Generic;

*/



