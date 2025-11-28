

/*
Creating and Adding
A list is a sequential data structure that can hold any type. Like 
arrays
Preview: Docs Loading link description
, it can store any type of sequential information.

We create a list using the new keyword. We specify the element type inside angle brackets: < >. In this example, the list is named citiesList and it holds instances of the type string:

List<string> citiesList = new List<string>();

Copy to Clipboard

We can add elements to the list using the Add() method:

citiesList.Add("Delhi");

Copy to Clipboard

We can access elements using indices and square brackets:

string city = citiesList[0];

Copy to Clipboard

We can also re-assign elements using bracket notation:

citiesList[0] = "New Delhi";

Copy to Clipboard

To use 
lists
Preview: Docs Loading link description
, we’ll need to add this to the top of our file. We’ll explain this in detail later:

using System.Collections.Generic;
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      // Create a list to hold the top women’s marathon times in minutes. Create an empty list of type double and store it in a variable marathons.
      List<double> marathons = new List<double>();
      marathons.Add(144.07);
      marathons.Add(143.12);
      Console.WriteLine(marathons[1]);
      Console.WriteLine(string.Join(", ", marathons));
    }
  }
}
