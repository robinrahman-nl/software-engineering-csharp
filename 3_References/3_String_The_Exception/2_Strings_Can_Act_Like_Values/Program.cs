/*
Strings Can Act Like Values
String, or string, is a class that represents text. Technically, its value is stored as a collection of char objects.

Since it is a class, it is a reference type. However, in some cases, it behaves like a value type:

A string reference will always point to the original object, so “modifying” one reference to a string will not affect other references.
Comparing 
strings
Preview: Docs Loading link description
 with the equality operator (==) performs a value, not a referential comparison.
Here are two examples of the first behavior (modifying one reference doesn’t affect the others):

// Example 1
string dog = "chihuahua";
string tinyDog = dog;
dog = "dalmation";
Console.WriteLine(dog);
// Output: "dalmation"
Console.WriteLine(tinyDog);
// Output: "chihuahua"

// Example 2
string s1 = "Hello ";
string s2 = s1;
s1 += "World";
System.Console.WriteLine(s1);
// Output: "Hello World"
System.Console.WriteLine(s2);
// Output: "Hello"

Copy to Clipboard

This can be explained by the fact that strings are immutable: they cannot be changed after they are created. Anything that appears to modify a string actually returns an entirely new string object.

Here’s an example of the second behavior (value-like comparisons):

string s = "hello";
string t = "hello";
// b is true
bool b = (s == t);

Copy to Clipboard

Typically, we want to compare strings by value, so this makes it easier to write in code, and it also gives the C# compiler flexibility in how it implements the program — it doesn’t have to worry about where the actual string value is stored.
*/

using System;

namespace StringTheException
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create two string variables with the same value: "immutable".
            string s1 = "immutable";
            string s2 = "immutable";

            // 2. Compare the two variables using == and print the result. 
            // Why does this return true?
            bool b1 = (s1 == s2);
            Console.WriteLine(b1); // True

            // Because here we are comparing the stored values.   

            // 3. 
            // Now repeat the process with two Object variables:
            // Construct two new Object instances and store them in two new variables
            // Compare them with ==
            // Make sure to call new Object() twice. Why are the results different?
            Object o1 = new Object();
            Object o2 = new Object();
            

            bool b2 = (o1 == o2);
            Console.WriteLine(b2); // False

            // Why are the results different?
            // because we are here comparing 2 references.
            


        }
    }
}
