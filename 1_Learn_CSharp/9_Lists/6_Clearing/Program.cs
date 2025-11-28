// See https://aka.ms/new-console-template for more information

/*
Clearing
If we need to remove all of the elements from a list, we could iterate through the entire list and call Remove(). The easier way is to use the Clear() method:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kyiv" };
citiesList.Clear();

Console.WriteLine(citiesList.Count);
// Output: 0

*/

List<double> marathons = new List<double>
      {
        148.22,
        156.10,
        153.88,
        155.34,
        160.89
      };

// Clear the list here
marathons.Clear();

Console.WriteLine($"Count: {marathons.Count}");
