using System;

namespace MadTeaParty
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Introduction to Working with Text
Working with text is a fundamental part of writing programs. Whether it’s to provide instructions to a user, gather data like a name or address, or write a new form of poetry, text enables us to bring human language into computational form.

In this lesson, we’ll look at the two commonly used text 
data types
Preview: Docs Loading link description
 in C#: char and string. By the end of this lesson, you will be able to manipulate textual data and write programs that take in user inputs and output customizable messages using 
variables
Preview: Docs Loading link description
, 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
, and built-in 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
.

Instructions
Take a look at the program on the right. What do you think the outcome will be? This program uses many of the techniques that you’ll learn in this lesson!

Concept Review
Want to quickly review some of the concepts you’ve been learning? Take a look at this material's cheatsheet!
      */



      string drink = "wine";
      string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

      int storyLength = madTeaParty.Length;
      string toFind = "March Hare";

      string findLowerCase = toFind.ToLower();
      int findMarchHare = madTeaParty.IndexOf(toFind);

      Console.WriteLine(madTeaParty.Substring(findMarchHare));
      Console.WriteLine($"This scene is {storyLength} long.\n");                                                // This scene is 211 long.
      Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");    // The term we're looking for is March Hare and is located at index 22.
    }
  }
}
