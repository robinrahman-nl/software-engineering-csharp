// See https://aka.ms/new-console-template for more information

/*
Get Info About Strings
In addition to containing the value of a piece of text, strings also include information about themselves. It can be helpful to know these properties when working with strings. There are several built-in .NET 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 that we can use to get more information about strings.

Length
Since strings are composed of a set of characters, we can find out how many characters exist in a string with the 
.Length
Preview: Docs Loading link description
 method. A common example is if we’re building a form and must ensure a user submission does not exceed a certain character length.

string userTweet = Console.ReadLine();

userTweet.Length; // Returns the length of the tweet

Copy to Clipboard

We append the .Length property to a string that we have, such as a user’s tweet.

IndexOf
We can also find the position of a specific character or substring using 
.IndexOf()
Preview: Docs Returns the index of a specified character or substring in a string.
. This method is useful for checking if something exists in a string.

If it does exist within a string, the method will return the position of the search term in the larger string. Each character in a string has a unique position, like an address. Positions start at 0 and increment by 1.

string word = "radio";

word.IndexOf("a"); // Returns 1

Copy to Clipboard

Since positioning starts at 0, the second thing in the string will return a 1. If it does not exist in the string, the method will return a -1. If we pass it an empty string, it will return 0. If it occurs more than once, it will return the first instance.
*/

// Create password
string password = "a92301j2add";

// Get password length
int passwordLength = password.Length;

// Check if password uses symbol
int passwordCheck = password.IndexOf("!");

// Print results
Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
