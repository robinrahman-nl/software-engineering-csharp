/*
Arithmetic Operators
So what can we do with numerical data? A common use is to write expressions using arithmetic operators.

Arithmetic 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
 include:

addition +
subtraction -
multiplication *
division /
We can use these symbols to perform operations on numbers and create new values.

int answer = 4 + 19;

Console.Write(answer);
// Prints 23

Copy to Clipboard

When using operators, it’s important to pay attention to 
data types
Preview: Docs C-sharp supports many data types that represent the size and kind of values being stored in memory.
. If we use two integers, it will return an integer every time. However, when two different numerical types are used with an arithmetic operator, the result will always be of the type that is more precise. So, if we use an int with a double, the result will be a double.

Let’s look at the following example:

Console.WriteLine(5 / 3);
Console.WriteLine(5 / 3.0);

// Prints 1
// Prints 1.66667

Copy to Clipboard

The first operation that we log uses two ints. While 3 doesn’t go into 5 evenly, we are still left with an int as the result. Note that with integer division, any decimal portion of the result is truncated, not rounded.

In the second operation, we use an int and a double, so the final result is a double, as a double is more precise than an int.

C# follows a specific order of operations to determine which operator(s) should be assessed first when multiple operators are used in a single expression. In terms of arithmetic operators, the order is:

Parentheses: () — Operators within parentheses will be assessed before those outside parentheses. If one set of parentheses is nested within another, the nested group will be assessed before the outer group.
Multiplicative: *, /, % — % is the modulo operator, which we will cover later in this lesson.
Additive: +, -
When two operators of the same group are used together without parentheses, the operators are assessed from left to right.

So, if we calculate 1 + 2 * 3, will the answer be 9 or 7? The correct answer is 7, as the order of operations dictates that multiplication will be assessed before addition.

It’s a good practice to use parentheses to explicitly tell C# how to calculate these expressions — 1 + (2 * 3) is functionally equivalent, but avoids confusion as to what order the expression will be evaluated in.

The following example shows how moving the placement of the parentheses alters the order in which the operations are evaluated:

int answer = 1 + 2 * 3; // 7 - multiplication is assessed first based on operator precedence
answer = 1 + (2 * 3);   // 7 - multiplication is assessed first because it is in parentheses
answer = (1 + 2) * 3;   // 9 - addition is assessed first because it is in parentheses

*/

using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {
      // Your Age
      int userAge = 44;


      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;


      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;


      // Log calculations to console
      Console.WriteLine(userAge);
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
    }
  }
}
