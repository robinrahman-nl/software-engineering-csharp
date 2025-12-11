/*
Strings can be Null or Empty or Unassigned
Like other reference types, string references can be null or unassigned, but they can also have a third “nothing” value: empty.

// Unassigned
string s;
// Null
string s2 = null;
// Empty string
string s3 = "";
// Also empty string
string s4 = String.Empty;
// This prints true
Console.WriteLine(s3 == s4);

Copy to Clipboard

All of these signify a lack of text, but they each mean something slightly different:

Unassigned means that the programmer did not give the variable any value.
Null means that the programmer intentionally made the variable refer to no object.
An empty string signifies a piece of text with zero characters. This is often used to represent a blank text field. It can be represented by "" or String.Empty.
The Microsoft Programming Guide suggests using String.Empty or "" instead of null to avoid NullReferenceException errors.

We can check for null OR empty 
strings
Preview: Docs Loading link description
 using the static String method IsNullOrEmpty(). It’s explained in more detail in the documentation.
*/

using System;

namespace StringTheException
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can check for null OR empty strings using the static String method IsNullOrEmpty().

            // 1. Using Console.Write() and Console.ReadLine(), ask the user for input and capture it in a variable.
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();

            


            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("You didn't enter anything!");
            }

            else
            {
                Console.WriteLine("Thank you for your submission!");
            }

            Console.WriteLine($"Username : {userInput}");
        }
    }
}
