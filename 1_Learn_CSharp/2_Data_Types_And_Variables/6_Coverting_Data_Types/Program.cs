/*
Converting Data Types
Because 
variables
Preview: Docs Variables are used to store and manipulate data. In C#, each variable has a type that determines the values it can store.
 have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.

For example, let’s try converting a double to an integer:

double positiveDouble = 3.2;

// Convert positiveDouble to an int
int positiveInt = positiveDouble;

Copy to Clipboard

But if you tried to run this code, it wouldn’t work.

However, if you did the reverse and turned an int into a double:

int positiveInt = 3;
// Turn it into a double
double positiveDouble = positiveInt;

Copy to Clipboard

It’s fine! Why is that?

C# checks to make sure that when we convert 
data types
Preview: Docs Loading link description
 from one to another that we’re not losing any data because that could cause problems in our code.

Because of that, there are a couple of different ways to do data type conversion:

implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
explicit conversion: requires a cast operator to convert a data type into another one. If we do want to convert a double to an int, we could use the operator (int).
So, to fix the error in our previous code, we’d rewrite it as follows:

double positiveDouble = 3.75
double negativeDouble = -3.75;

// casting double to int truncates the decimal portion
int positiveInt = (int)positiveDouble; // 3
int negativeInt = (int)negativeDouble; // -3

Copy to Clipboard

It’s also possible to convert data types using built-in 
methods
Preview: Docs Loading link description
. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble(). For a full list of Convert class built-in methods, check out the Microsoft Documentation.
*/

using System;
using System.Runtime.Intrinsics.Arm;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {

      // Attempt 1: use implicit conversion
      // int faveNumber = Console.ReadLine();

      // Attempt 2: use explicit conversion
      // int faveIntNumber = (int)Console.ReadLine();

      // Attempt 3: use Convert class. 

      Console.ReadLine();
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(faveNumber);


    }
  }
}
