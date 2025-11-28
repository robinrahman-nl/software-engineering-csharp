// See https://aka.ms/new-console-template for more information
/*
Array Length
We often want to know how many items an array contains. We can find this using the 
.Length
Preview: Docs Loading link description
 property.

int[] plantHeights = { 3, 4, 6 };

// arrayLength will be 3
int arrayLength = plantHeights.Length;

Copy to Clipboard

Using the .Length property will return the number of items in an array and 0 if the array is empty.
*/


string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

if (summerStrut.Length == 8)
{
  Console.WriteLine("summerStrut Playlist is ready to go!");
}
else if (summerStrut.Length > 8)
{
  Console.WriteLine("Too many songs!");
} else
{
    Console.WriteLine("Add some songs!");
}

