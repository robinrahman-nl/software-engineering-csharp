// See https://aka.ms/new-console-template for more information

/*
Built-In Methods
In C#, there are several built-in 
methods
Preview: Docs Loading link description
 we can use with 
arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
. A complete list can be found in the Microsoft documentation of the Array class.

Sort
The built-in method Array.Sort(), as its name suggests, sorts an array. This method is a quick way to further organize array data into a logical sequence:

int[] plantHeights = { 3, 6, 4, 1 };

// plantHeights will be { 1, 3, 4, 6 }
Array.Sort(plantHeights); 

Copy to Clipboard

Sort() takes an array as a parameter and edits the array so its values are sorted. If it is an array of integer values, it will sort them into ascending values (lowest to highest). If it’s an array of string values, they would be sorted alphabetically.

IndexOf
The Array.IndexOf() method takes a value and returns its index within the array. IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!).

int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

 // Returns 1
Array.IndexOf(plantHeights, 6);

Copy to Clipboard

IndexOf() typically takes 2 parameters: the first is the array and the second is the value whose index we’re looking for. IndexOf() also has several overloads that allow you to search for a specific range of the array.

If the value appears more than once in an array, it returns only the index of the first occurrence within the specified range. If it does not find the value at all, it returns -1.

Reverse
The Array.Reverse() method returns the array with the original elements in reverse order.

int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

// plantHeights will be { 8, 6, 1, 4, 6, 3 }
Array.Reverse(plantHeights);

Copy to Clipboard

Reverse() takes just one parameter, the given array to be reversed.
*/

string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

// Using an Array method, find the position for the first 3-star rated song and save it to a variable.
int first3StarSong = Array.IndexOf(ratings, 3) + 1;

// Print a message to the console, like “Song number X is rated three stars”.
Console.WriteLine($"Song number {first3StarSong} is rated three stars"); // Song number 4 is rated three stars

// Using an Array method, reverse the order of the titles in summerStrut. Print out the first and last titles to confirm that the elements have been reordered.
Array.Reverse(summerStrut);

Console.WriteLine($"{summerStrut[0]} {summerStrut[7]}");


// 3.
// Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
Array.Sort(summerStrut);
Console.WriteLine(summerStrut);   // System.String[]
Console.WriteLine($"{summerStrut[0]} {summerStrut[7]}");


