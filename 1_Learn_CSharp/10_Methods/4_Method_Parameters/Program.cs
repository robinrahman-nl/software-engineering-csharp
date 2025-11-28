/*
Method Parameters
Remember calling 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 with arguments, like Math.Min(3, 4)? We can define methods with arguments as well.

While defining our method, we do not know the argument values that will be used when calling the method, but we do define the data type and how it will be used. We can use this information to define a parameter which acts as an input variable within a method. Imagine it as a placeholder for the actual argument value.

static void OurMethodName(string identity)
{
  Console.WriteLine(identity);
}

Copy to Clipboard

The OurMethodName() method now has one parameter named identity of type string.

Multiple parameters can be defined within a single method definition, separated by commas:

static void OurMethodName(string identity, int age)
{
  Console.WriteLine($"{identity} is {age} years old.");
}

Copy to Clipboard

When you call your method, the values passed in that correspond to each parameter are called arguments. In the following code, "Jill" and 34 are arguments for the identity and age parameters respectively.

OurMethodName("Jill", 34);

Copy to Clipboard

NOTE: Parameters can only be used inside the method that defines them.

The following example defines a method YourMethodName that takes a string parameter, message. message is also referenced within the Main method.

static void Main(string[] args)
{
  Console.WriteLine(message); // causes an error!
}

static void YourMethodName(string message)
{
  Console.WriteLine(message);
}

Copy to Clipboard

If you run this code, it will result in an error because message does not exist within the context of the Main method. The error would look like…

error CS0103: The name 'message' does not exist in the current context 

Copy to Clipboard

when talking to other developers about this type of issue, you might hear the term scope. While the entire concept of scope won’t be covered in this lesson, you should know how it applies here: a parameter’s scope is within its method, which means that the name (message in this case) is only valid within its method. If the parameter name is used outside the method, it has no meaning, so it throws an error.
*/

using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
        {
      VisitPlanets(3);
      VisitPlanets(100);
      VisitPlanets(25);
        }

    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
    
   

  }
}

