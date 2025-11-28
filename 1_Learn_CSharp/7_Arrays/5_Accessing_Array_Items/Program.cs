// See https://aka.ms/new-console-template for more information
/*
Accessing Array Items
Arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
 are useful for storing values, but they become more useful when there is a way to access them.

Arrays order items so that they’re in a specific sequence, which makes it easy to access a specific item. Each value has a position in the array, which is known as its index. We can think of an index as an address — it’s what we use to locate an item in an array. In C#, arrays start their index at 0 and then increment by 1 for each value.

annotated code for accessing array values. an array of strings named "cities" is initialized with three values, "New York", "Beijing", and "Nairobi", in that order. "New York" is at index 0, "Beijing" is at index 1, and "Nairobi" is at index 2. on another line, "New York" is accessed by using the array name, "cities", followed by square brackets containing the corresponding index value, 0.

To access a value from a list, we write out the name of the array, followed by brackets []. Within the brackets, we specify the index number of the value we want:

int[] plantHeights = {3, 4, 6};

// plantTwoHeight will be 4
int plantTwoHeight = plantHeights[1];

Copy to Clipboard

We can now access that value and utilize it later in our program.
*/

string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");
