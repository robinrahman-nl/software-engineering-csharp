// See https://aka.ms/new-console-template for more information

/*
Building Strings
A string is a group of characters surrounded by quotation marks, like "https://codecademy.com" or "To be or not to be." A string is just a collection of a smaller data type, char, which is a single character like “a” or “?”.

To define a variable as a string, you write the data type and then the variable name. Then, set it equal to the value, which is inside of quotation marks:

string variableName = "puppy";

Copy to Clipboard

The variable is named variableName, it’s of type string, and its value is "puppy".

Escape Character Sequences
What happens when you need to include quotes in a string? You can use an escape sequence. An escape sequence places a backslash (\) before the inner quotation marks so the program doesn’t read them accidentally as the end of the sequence.

string withoutSlash = "Ifemelu said, "Hello!"";

string withSlash = "Ifemelu said, \"Hello!\"";

Copy to Clipboard

We can use escape character sequences to create a new line. That means that when we print the string to the console, it will print that line below the rest. If printed on its own, it will create an empty line. To make a new line, use the character combination \n.

string newLine = "Ifemelu walked \n to the park.";

Copy to Clipboard

For more on escape sequences, check out Microsoft’s Documentation.
*/


// First string variable
string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";

// Second string variable
string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

// Print variable and newline
Console.WriteLine(firstSentence);
Console.WriteLine();
Console.WriteLine(firstSpeech);

