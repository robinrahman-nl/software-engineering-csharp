// See https://aka.ms/new-console-template for more information

/*
Get Parts of Strings
We can also use built-in .NET 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 to grab parts of strings or specific characters in a string.

Substring
.Substring()
Preview: Docs Loading link description
 grabs part of a string using the specified character position, continues until the end of the string, and then returns a new string. 
.IndexOf()
Preview: Docs Returns the index of a specified character or substring in a string.
 is usually used first to get the specific character position.

string plantName = "Cactaceae, Cactus"; 
int charPosition = plantName.IndexOf("Cactus"); // Returns 11
string commonName = plantName.Substring(charPosition); // Returns Cactus

Copy to Clipboard

.Substring() is useful if we only want to use part of a string but keep the original data intact. So in this instance, we want to keep the string plantName, but just grab the "Cactus" portion of the string. We use .IndexOf() to find where "Cactus" starts, then use .Substring() with the position information to save "Cactus" to the new variable commonName.

We can also pass .Substring() a second argument, which will determine the number of characters in the resulting substring. For example, the following code shows how we can use .Substring() with two arguments to specify the length of our substring:

string name = "Codecademy"; 
int start = 2;
int length = 6;
string substringName = name.Substring(start, length); // Returns 'decade'

Copy to Clipboard

Bracket Notation
Bracket notation is a style of syntax that uses brackets [] and an integer value to identify a particular value in a collection. In this case, we can use it to find a specific character in a string.

string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // Returns 15
char u = plantName[charPosition]; // Returns u

Copy to Clipboard

Similar to the example above, we first use .IndexOf() to grab the character position, which in this case is 15. We then take the string value and append it with a set of brackets [] and place the charPosition value inside the brackets.
*/

// dna strand
string startStrand = "ATGCGATGAGCTTAC";

// find location of "tga"
int tga = startStrand.IndexOf("TGA");       // 6

// start point and stop point variables
int startPoint = 0;
int length = tga + 3;

// define final strand
string dna = startStrand.Substring(startPoint, length);
Console.WriteLine(dna);
// DNA mutation search
Console.WriteLine(dna[3]);

// if (dna[4] == 'C') { Console.WriteLine("There is no Mutation"); } 
// else { Console.WriteLine("Mutation found");}