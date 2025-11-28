/*
Modulo
One arithmetic operator that we haven’t covered yet is modulo. A modulo returns a remainder, the value left over when we divide a number by another number.

// 7 / 3 = 2 with 1 remaining, 2 * 3 = 6, and 6 + 1 = 7
7 % 3 = 1 

// 4 / 2 = 2 with no remainder
4 % 2 = 0  // The remainder is 0

Copy to Clipboard

Modulo uses the percentage symbol, but it’s important to remember it has a different meaning in this context.

Modulo is useful because it lets us know if a number “fits” into a larger number, or if there will be a remainder. For example, how many eggs will be left over if we try to fit 56 eggs into crates that hold 12 each?

int eggs = 56;
int crateCapacity = 12;

int eggsLeftOver = eggs % crateCapacity; 
// 56 / 12 = 4 (12*4 = 48) with 8 remaining
// we can confirm this is correct because 48 + 8 = 56
Console.Write(eggsLeftOver); // Prints 8

Copy to Clipboard

It can also be used to check if a number is odd or even. If a number is even, taking its modulo with 2 will return a 0, and if it is odd it will return a 1:

int myNum = 85939824;
Console.Write(myNum % 2); // Prints 0, so number is even

*/


using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;


      // Number of students in a group
      int groupSize = 3;
    

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}
