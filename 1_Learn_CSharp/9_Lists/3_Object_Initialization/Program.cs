// See https://aka.ms/new-console-template for more information

/*
Object Initialization
Our first way to create 
lists
Preview: Docs A List in C# is a dynamic data structure that stores multiple objects of a specified type.
 and add items took multiple lines:

List<string> citiesList = new List<string>();
citiesList.Add("Delhi");
citiesList.Add("Los Angeles");

Copy to Clipboard

We can do it all in one line using object initialization:

List<string> citiesList2 = new List<string> { "Delhi", "Los Angeles" };

Copy to Clipboard

Basic construction uses parentheses ( ) and no values.
Object initialization uses curly braces { } and the actual values go in-between.
If we need to add elements to that second list later, we can still use Add():

citiesList2.Add("Kyiv");

Copy to Clipboard

Instructions
Checkpoint 1 Enabled
1.
The current code creates an empty list and uses Add() to add elements.

Delete those lines and make the same list with an object initialization.
*/

List<double> marathons = new List<double>{144.07, 143.12, 146.73, 146.33};
// marathons.Add(144.07);
// marathons.Add(143.12);
// marathons.Add(146.73);
// marathons.Add(146.33);

// Do not delete the code below
double time = marathons[1];

Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");