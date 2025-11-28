// See https://aka.ms/new-console-template for more information

/*
Working with Ranges
So far, we have added, accessed, and removed single elements from the list. What if we wanted to add, access, or remove multiple elements?

We call a subsequence of a list a range. For example, this list has 5 elements:

[ "first", "second", "third", "fourth", "fifth" ]

Copy to Clipboard

We can say the range of elements from index 1 to 3 is:

[ "second", "third", "fourth" ]

Copy to Clipboard

Here are four common range-related methods:

AddRange() — takes an array or list as an argument. Adds the values to the end of the list. Returns nothing.
InsertRange() — takes an int and array or list as an argument. Adds the values at the int index. Returns nothing.
RemoveRange() — takes two int values. The first int is the index at which to begin removing, and the second int is the number of elements to remove. Returns nothing.
GetRange() — takes two int values. The first int is the index of the first desired element, and the second int is the number of elements in the desired range. Returns a list of the same type.
Here is each one in action:

List<string> places = new List<string> { "first", "second" };

places.AddRange(new string[] { "fifth", "sixth" });
// List is  "first", "second", "fifth", "sixth" ]
places.InsertRange(2, new string[] { "third", "fourth"});
// List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
places.RemoveRange(4, 2);
// List is [ "first", "second", "third", "fourth" ]
List<string> newPlaces = places.GetRange(0, 3);
// New list is [ "first", "second", "third" ]

Copy to Clipboard

You don’t need to memorize these 
methods
Preview: Docs Loading link description
, but you should be familiar with the concept of ranges! You can always look up the methods again in the Microsoft documentation.
*/


List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };


marathons.AddRange(100, 200);
Console.WriteLine(string.Join(" .", marathons)); // [144.07 .143.12 .146.73 .146.33 .100 .200]

marathons.AddRange(new double[] { 100.1, 200.2 });
Console.WriteLine(string.Join(" .", marathons));  // [144.07 .143.12 .146.73 .146.33 .100 .200 .100.1 .200.2]

marathons.InsertRange(0, new double[] { 500.1, 500.2 });
Console.WriteLine(string.Join(" .", marathons)); // [500.1 .500.2 .144.07 .143.12 .146.73 .146.33 .100 .200 .100.1 .200.2]

marathons.RemoveRange(0, 2);
Console.WriteLine(string.Join(" .", marathons)); // [144.07 .143.12 .146.73 .146.33 .100 .200 .100.1 .200.2]

List<double> topMarathons = marathons.GetRange(0, 3);
Console.WriteLine(string.Join(" .", topMarathons)); // [144.07 .143.12 .146.73]

foreach (double marathon in topMarathons)
{
    Console.WriteLine(marathon); // 144.07 // 143.12 // 146.73
}
