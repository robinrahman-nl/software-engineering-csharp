

/*
Switch Statements
Imagine that there were 100 values a variable could be, and we needed our program to act differently for each value. It would take a long time to write all of those conditions.

A switch statement is used for these types of situations. The switch statement is a shorter syntax for a series of conditional statements based on a single expression.

In C#, we write a switch statement using the following syntax:

int speed = 100;

switch (speed)
{
   case < 25:
      // Executes if the value of speed is less than 25
      Console.WriteLine("Going slowly");
      break;
   case 25:
      // Executes if the value of speed is equal to 25
      Console.WriteLine("Going at correct speed");
      break;
   case < 30:
      // Executes if the value of speed is between 25 and 30
      Console.WriteLine("Going slightly too fast");
      break;
   default:
      // The speed must be over 30 due to the above conditions
      Console.WriteLine("Going much too fast");
      break;
}

// Would print "Going much too fast"

Copy to Clipboard

A switch statement begins with the switch keyword, then has a switch expression in parentheses. After that, cases are defined relative to the switch expression.

The comparison after the case keyword is applied to the switch expression. When we say switch (speed) followed by case < 25:, the program checks whether speed is less than 25. Cases will check for equality when no Boolean operator is provided, such as with case 25.

The cases are evaluated in the order they are defined. When a case matches with the switch expression, the code block for that case is executed. When a case does not match the switch expression, the program moves on to the next case.

The code inside the default case will only run if no other case is met. The default case is optional in a switch statement.

Each case must end by using a keyword that instructs the program where to go next. For each case in the preceding example, we used the break keyword, which causes the program to exit the switch statement and continue executing after its closing curly brace (}). There are a few other keywords that can be used to exit a switch, including return and throw, which we will cover in later lessons. For now, however, you should end each case with a break statement.
*/

using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      double ph = 14;
      switch (ph)
      {
        case <= 3:
          Console.WriteLine("Very Acidic");
          break;
        case < 7:
          Console.WriteLine("Acidic");
          break;
        case >= 11:
          Console.WriteLine("Very Basic");
          break;
        case > 7:
          Console.WriteLine("Basic");
          break;
        default:
          Console.WriteLine("Neutral");
          break;

      }

      /*
      if (ph < 7)
      {
        Console.WriteLine("Acidic");
      }
      else if (ph > 7)
      {
        Console.WriteLine("Basic");
      }
      else 
      {
        Console.WriteLine("Neutral");
      }
      */

    }
  }
}
