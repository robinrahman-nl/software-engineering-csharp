// See https://aka.ms/new-console-template for more information

/*
Removing
We use the Remove() method to remove a specific item from a list. It expects the specific item as an argument and returns true if it has been removed. This code removes "Delhi" from the list and returns true:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kyiv" };
bool success = citiesList.Remove("Delhi");
// success is true

Copy to Clipboard

If the specific item does NOT exist in the list, the method call returns false. Since "Dubai" isn’t in the list, success will be false:

success = citiesList.Remove("Dubai");
// success is false

Copy to Clipboard

If you remove an element in the middle of the list, all of the elements will be “shifted” down one index. In the first example, the list was originally:

[ "Delhi", "Los Angeles", "Kyiv" ]

Copy to Clipboard

After the call to Remove("Delhi"), the list becomes:

[ "Los Angeles", "Kyiv" ]

*/

List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };

Console.WriteLine(marathons[1]); // prints 143.12

bool removed = marathons.Remove(143.12);

Console.WriteLine(marathons[1]);  // 146.73
Console.WriteLine(removed);     // true