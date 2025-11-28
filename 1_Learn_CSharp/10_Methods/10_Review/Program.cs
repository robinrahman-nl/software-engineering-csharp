/*
Review
In this lesson, we learned about 
methods
Preview: Docs Loading link description
, which allow us to define named blocks of custom code that can easily be reused.

Here’s what we covered:

Methods can be called by adding parentheses to the end of the method name.
Every time an application is started, the Main() method is called.
Methods can return values as output. Method outputs can be stored in 
variables
Preview: Docs Loading link description
 for later use.
A basic method can be defined using the following syntax:
static void BasicMethod()
{
  // method implementation
}

Copy to Clipboard

Arguments are values passed to a method call, between the parentheses.
Parameters in a method signature define variables that will serve as placeholders for arguments passed when the method is called.
Method parameters can only be used within the method body.
In method overloading, multiple methods can have the same name, as long as they have different method signatures.
Method parameters can be optional if given a default using equals (=) syntax.
When calling a method, arguments can be passed by position or by name. If using names, use the colon (:) syntax.
Methods return values with the return keyword.
We can define a type and value for a method to return.
Every method has a return type, designated in its method signature. That type must match the type of the value actually returned.
If a method returns no type, its return type is void.
out parameters can be used to return multiple values from a method.
*/

// Review the code in the editor which utilizes many of the concepts covered in this lesson. For practice, try experimenting with the existing methods or create your own!

using System;

namespace MethodsReview
{
  class Program
  {
    /*
      this method takes two parameters, "name" and "petType"
      "name" is a required parameter
      "petType" is optional, defaulting to "cat" if no value is passed
      the return type is defined as "string", which matches the value that is returned
    */
    static string IntroducePet(string name, string petType = "cat") 
    {
      string introduction = $"This is my {petType}, {name}!";
      return introduction;
    }

    /*
      an override of IntroducePet that accepts
      an integer "age", which is incorporated into
      a more detailed output string
    */
    static string IntroducePet(string name, int age, string petType = "cat")
    {
      string introduction = $"This is my {petType}, {name}! {name} is {age} years old!";
      return introduction;
    }

    // when the program is run, Main() is executed
    static void Main(string[] args)
    {
      // IntroducePet called with one argument
      // "petType" parameter defaults to "cat"
      string mittensIntro = IntroducePet("Mittens");
      Console.WriteLine(mittensIntro);

      // a positional argument is passed to "petType"
      string franklinIntro = IntroducePet("Franklin", "turtle");
      Console.WriteLine(franklinIntro);

      // a named argument is passed for "petType"
      string spotIntro = IntroducePet("Spot", petType: "dog");
      Console.WriteLine(spotIntro);

      // using the override with "int age"
      string berthaIntro = IntroducePet("Bertha", 7, "cow");
      Console.WriteLine(berthaIntro);
    }
  }
}
