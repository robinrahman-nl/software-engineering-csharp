/*
Optional Parameters
To make our functions even more flexible, we can make certain parameters optional. If someone calls our method without all the parameters, the method will assign a default value to those missing parameters.

We use the equals sign (=) when defining an optional method parameter. In this example, punctuation is optional, and its default value is ".".

static void OurMethodName(string message, string punctuation = ".")
{
  Console.WriteLine(message + punctuation);
}

static void Main(string[] args)
{
  OurMethodName("I'm hungry", "!"); // prints "I'm hungry!"
  OurMethodName("I'm hungry");  // prints "I'm hungry."
}

*/



using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      VisitPlanets();   // Call the method without the optional parameter
    }
    
    // Update the existing parameter so that it is optional and its default value is 0.
    static void VisitPlanets(int numberOfPlanets = 100) // We use the equals sign (=) when defining an optional method parameter
    {

      Console.WriteLine($"You visited {numberOfPlanets} new planets...");

    }
  }
}


