// See https://aka.ms/new-console-template for more information

/*
Introduction to Lists
At this point, we assume that you’re familiar with arrays: they’re useful tools for managing large amounts of sequential data.

But 
arrays
Preview: Docs Loading link description
 have their drawbacks:

They have a limited length.
We have to keep track of the number of elements in the array using a separate index.
We can only edit one element at a time.
Lists resolve all of these issues. Like arrays, they are a sequential collection of values and can hold references to any type. Unlike arrays, they:

Have (effectively) unlimited length.
Automatically track the number of elements in the list.
Have 
methods
Preview: Docs Loading link description
 to work with multiple elements at a time.
When constructing a list, the C# compiler constructs an array and stores the elements there. If the list gets longer than the array’s length, the compiler copies the list’s elements to a new, longer array. To the developer, it looks like the list is infinitely long.

Arrays are faster to use when we have a pre-determined number of elements. 
Lists
Preview: Docs A List in C# is a dynamic data structure that stores multiple objects of a specified type.
 are better when the number is unknown and they have extra features.

In this lesson, we’ll cover list basics and some common list methods.

Instructions
Checkpoint 1 Enabled
1.
This code creates and edits a lists of cities. How does this look different from arrays?

Run the code to see it in action.
*/

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

citiesList.Add("New York City");

citiesList.Remove("Delhi");

citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

bool hasNewDelhi = citiesList.Contains("New Delhi");

foreach (string city in citiesList)
{
  Console.WriteLine(city);
}


