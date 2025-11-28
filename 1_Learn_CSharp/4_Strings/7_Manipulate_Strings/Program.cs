// See https://aka.ms/new-console-template for more information
/*
Manipulate Strings
There are also built-in .NET 
methods
Preview: Docs Loading link description
 that we can use to manipulate text data. Using these methods on a string doesn’t change the string itself but creates an entirely new one.

ToUpper, ToLower
We can quickly change the case of our strings using the methods 
.ToUpper()
Preview: Docs Loading link description
 and 
.ToLower()
Preview: Docs Loading link description
. These methods are useful if we want to make our text to be all capitalized or all lowercase, respectively.

string shouting = "I'm not shouting, you're shouting".ToUpper();
Console.WriteLine(shouting);
// Prints I'M NOT SHOUTING, YOU'RE SHOUTING.
*/

// Script line
string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

// Get camera directions
int charPosition = script.IndexOf("Close");
int length = "Close on".Length;
string cameraDirections = script.Substring(charPosition, length);

// Get scene description
charPosition = script.IndexOf("a portrait");
string sceneDescription = script.Substring(charPosition);

// Make camera directions uppercase
cameraDirections = cameraDirections.ToUpper();

// Make scene description lowercase
sceneDescription = sceneDescription.ToLower();

// Print results
Console.WriteLine(cameraDirections + sceneDescription);

/*
Review
Great job! You just learned about how to work with textual data in a few different ways:

How to save char and string values to a variable.
Use the addition symbol (+) to concatenate strings.
Interpolate strings for easier string construction.
Find information about a string using 
.Length
Preview: Docs Loading link description
 and 
.IndexOf()
Preview: Docs Returns the index of a specified character or substring in a string.
.
Grab characters and parts of strings using bracket notation and 
.Substring()
Preview: Docs Loading link description
.
Use built-in 
methods
Preview: Docs Loading link description
 such as 
.ToUpper()
Preview: Docs Loading link description
 and 
.ToLower()
Preview: Docs Loading link description
 to manipulate strings.
*/