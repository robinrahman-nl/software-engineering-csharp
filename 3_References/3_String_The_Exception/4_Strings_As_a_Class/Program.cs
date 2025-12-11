/*
String as a Class
We can confirm that String is a class by looking up the String class documentation and trying some of the 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 and properties listed there.

This example uses Length and Contains().

string s = "Hello World";
Console.WriteLine(s.Length); // Prints 11
Console.WriteLine(s.Contains("o")); // Prints True

Copy to Clipboard

The Contain() method takes either a string or char as an argument and will return true if it occurs within the string object the method is called on. Otherwise, it returns false.

We’ve already seen one static property, Empty and one static method, IsNullOrEmpty():

string s = String.Empty;
bool isEmpty = String.IsNullOrEmpty(s); // true

Copy to Clipboard

Another useful string method is Replace(), which takes two string arguments. It takes the string object it is called on, finds every instance of the first argument, and replaces each with the second argument, then returns the result:

string s = "thud ud a test";
s = s.Replace("ud", "is");
Console.WriteLine(s); // Prints "this is a test"

Copy to Clipboard

Instructions
Checkpoint 1 Enabled
1.
Let’s practice using Replace(String, String) to update the formatting of a string.

We’ve created a string dates that contains several dates on new lines, but you think they would look better without the “-th” suffix on the day.

Call Replace() on dates, passing "th" as the first argument and an empty string as the second (null will also work).
*/

using System;

namespace StringTheException
{
    class Program
    {
        static void Main(string[] args)
        {

            // Let’s practice using Replace(String, String) to update the formatting of a string.
            // We’ve created a string dates that contains several dates on new lines, but you think they would look better without the “-th” suffix on the day.

            // 1.  
            // Call Replace() on dates, passing "th" as the first argument and an empty string as the second (null will also work).
            string dates =
              "January 4th, 2024\n" +
              "March 25th, 2024\n" +
              "July 8th, 2024\n" +
              "December 11th, 2024";

            // Call `Replace()` here
            dates =   dates.Replace("th", null);


            Console.WriteLine(dates);
        }
    }
}
