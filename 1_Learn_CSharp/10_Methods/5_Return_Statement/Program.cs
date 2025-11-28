/*
Return Statement
We can have a method return a value by providing a return type in its signature and using the return keyword in the method body.

The return keyword tells the computer to exit the method and return a value to wherever the method was called.

Let’s start with an example in the below code. It contains a definition of the Triple() method, which returns an int:

static int Triple(int num) 
{
  return num * 3;
}

public static void Main()
{
  int output = Triple(4);
  Console.WriteLine(output); // 12
}

Copy to Clipboard

When we execute this program, the code in Main() runs first:

Triple() is called.
In Triple(), the value of num multiplied by 3 is calculated and returned.
Back in Main(), that returned value is stored in the variable output and then printed to the console.
When a method is declared, it must announce the type of value it will return. In this case, Triple() returns an int, so it uses the int modifier located just before the name Triple.

Using the return type of void indicates that the method does not return a value.
*/

using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(      DecoratePlanet("Jupiter")
      );
    }
    
    static string DecoratePlanet(string planetName)
        {
      return $"*.*.* Welcome to {planetName} *.*.*";
        }

	}
}
