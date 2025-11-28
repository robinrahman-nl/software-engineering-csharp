/*
Numerical Data Types
In C#, there are several ways of representing numerical data. Your usage of each will depend on your application. When choosing a data type, think about the following questions:

Do we need a whole number or a number that includes a decimal?
If we want to use a decimal, how precise does it need to be? Depending on your application, whether it’s a hobby project or building financial software for businesses, you’ll need a different data type.
Is performance a factor? Most times, choosing a data type that takes up less memory will result in faster applications.
Let’s look at two 
data types
Preview: Docs Loading link description
 that we can use to represent different numerical values:

Int
An int is a whole integer value, like 4, 100, or -2349. They are for counting individual units of things. For example, if we wanted to track the number of coin flips a user makes, we’d use an integer. It doesn’t make sense to have 0.5 coin flips!

To define a variable with the type int, we would write something like the following:

int variableName = 7;

Copy to Clipboard

Double and Decimal
If we need to use a decimal value, we have a few options: float, double, and decimal. These values are useful for anything that requires more precision than a whole number, like measuring the precise location of an object in 3D space.

A double is usually the best choice of the three because it is more precise than a float, but faster to process than a decimal. However, for financial applications, be sure to use a decimal, as it is the most precise.

To define a variable with the type double, we would write something like:

double variableName = 39.76876;

Copy to Clipboard

To define a variable with the type decimal, you would write it as follows:

decimal variableName = 489872.76m;

Copy to Clipboard

Don’t forget the m character after the number when creating a decimal! This character tells C# that we’re defining a decimal and not a double. Similarly, when creating a float, the number must be followed by the character f:

float variableName = 489872.76f;

Copy to Clipboard

doubles may also be created with a trailing d, however, this is not required like m and f are for decimals and floats:

// both of these are valid double declarations
double variableOne = 39.766;
double variableTwo = 42.686d;

*/

using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;


      // Number of employees
      int totalEmplyees = 86928;

      // Revenue
      decimal revenue = 390819.28m;


      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmplyees);
      Console.WriteLine(revenue);
   	}
  }
}
