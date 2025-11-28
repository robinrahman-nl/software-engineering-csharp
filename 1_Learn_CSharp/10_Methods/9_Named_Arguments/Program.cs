/*
Named Arguments
Say our method has lots of optional parameters, but we only want to specify one when we call it.

In this example, our method has five optional parameters:

static void OurMethodName(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0) 
{
  Console.WriteLine($"{a}{b}{c}{d}{e}");
}

Copy to Clipboard

Let’s say that when we call this method, we only want to specify d. By default, calling the method with only one argument would set a to 4, not d, since a is the first parameter defined by the method definition. We call arguments passed like this positional arguments, as they correspond to the order that the parameters are defined in:

OurMethodName(4);
// Prints "40000"

Copy to Clipboard

Named arguments allow us to specify which parameter a given argument should be assigned to. We can refer to the parameter by its name using the following syntax:

OurMethodName(d: 4);
// Prints "00040"

Copy to Clipboard

With named arguments, we can also list them in any order:

OurMethodName(d: 4, b: 1, a: 2);
// Prints "21040"

Copy to Clipboard

We can also mix named arguments with positional arguments, but positional arguments must come before named arguments:

OurMethodName(5, 3, d: 2) 
// a is 5, b is 3, d is 2; Prints "53020"

OurMethodName(d: 4, 2, 1) // Error!

Copy to Clipboard

Named arguments aren’t always necessary, but they can be useful when:

a method has many optional parameters
we want to differentiate between similar arguments
*/

using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(name:"robin", numberOfPlanets: 2);
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}


