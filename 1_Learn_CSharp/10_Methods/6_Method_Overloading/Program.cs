/*
  Method Overloading
If we read the Microsoft documentation for Math.Round(), it has at least least 8 different versions! They all have the same name, Math.Round(), but each has a unique set of parameters.

This is using method overloading, and each “version” is called an overload. Though they have the same name, overloads have either:

different parameter types
different number of parameters
Overloading is useful when we want the same method to have different behavior based on its inputs. Let’s examine this concept with these two overloads:

Math.Round(Double, Int32)
Math.Round(Double)
The first overload, Math.Round(Double, Int32), rounds the double to the int‘s number of decimal points:

Math.Round(3.14159, 2); // returns 3.14

Copy to Clipboard

The second, Math.Round(Double), rounds the double to the nearest integer:

Math.Round(3.14159); // returns 3

Copy to Clipboard

We can overload a method by defining two 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 with the same name but different sets of parameters.

static int Add(int a, int b)
{
  return a + b;
}

static int Add(int a, int b, int c)
{
  return a + b + c;
}

*/

using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      IntroduceFriends("Laika", "Albert");
      IntroduceFriends("Naomi", "Jasmine", "Cyrus");
      IntroduceFriends();
    }

    // method overload 1
    static void IntroduceFriends(string friend_1, string friend_2)
    {
      Console.WriteLine($"These are my friends, {friend_1} and {friend_2}!");
    }

    // method overload 2
    static void IntroduceFriends(string friend_1, string friend_2, string friend_3)
    {
      Console.WriteLine($"These are my friends, {friend_1}, {friend_2} and {friend_3}!");
    }

    // method overload 3
    static void IntroduceFriends()
    {
      Console.WriteLine($"There is no one who needs to be introduced.");
    }
  }
}


