// See https://aka.ms/new-console-template for more information

/*
Count and Contains
We can check on the status of our list in two ways.

We can find the number of elements in the list using the Count property:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles" };
int numberCities = citiesList.Count;
// numberCities is 2

Copy to Clipboard

We can check if an element exists in a list using the Contains() method:

bool hasDelhi = citiesList.Contains("Delhi");
bool hasDubai = citiesList.Contains("Dubai");
// hasDelhi is true, hasDubai is false

*/

List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };

// 1. The list marathons has been initialized for you. Print the Count to the console.
Console.WriteLine(marathons.Count); // Prints 4

marathons.Add(143.23);
bool contains143_23 = marathons.Contains(143.23);

Console.WriteLine(contains143_23);

Console.WriteLine(marathons.Count); // prints 5


