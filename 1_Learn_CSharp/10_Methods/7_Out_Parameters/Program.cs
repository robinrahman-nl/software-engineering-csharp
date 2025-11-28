/*
Out Parameters
Sometimes we need to output multiple pieces of information. Calling a method that uses an out parameter is one way to return multiple values.

For example, the Int32.TryParse() method tries to parse its input as an int. If it can properly parse the input, the method returns true and sets its out variable to the new value. If it cannot properly parse the input, the method returns false and sets the out variable to 0.

This is what the method’s signature looks like:

public static bool TryParse (string s, out int result);

Copy to Clipboard

The method returns a bool and accepts a string and a variable that has been declared of type int as input.

Here’s how Int32.TryParse() and its out parameter are used:

int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is 0 and success2 is false

Copy to Clipboard

For a shortcut, we can declare the int variable within the method call:

bool success = Int32.TryParse("10602", out int number);

Copy to Clipboard

We can use out parameters in our own 
methods
Preview: Docs Loading link description
 as well. Any out parameter must be assigned a value within the method body. The last value assigned in the method will be available to the method’s caller.

Here we define area and perimeter out parameters and use their values in Main():

static void CalculateRectangle(int length, int width, out int area, out int perimeter)
{
    area = length * width;
    perimeter = 2 * (length + width);
}

static void Main()
{
    int length = 5;
    int width = 3;
        
    CalculateRectangle(length, width, out int area, out int perimeter);

    Console.WriteLine($"Area: {area}"); // Prints "Area: 15"
    Console.WriteLine($"Perimeter: {perimeter}"); // Prints "Perimeter: 16"
}

Copy to Clipboard

Using out parameters, we can now use multiple values coming from a method call.
*/

using System;
using System.Runtime.InteropServices;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string scoreAsString = "85.6";
      string statement = "Hello World";

      // 1.  define 2 variables:
      //     A bool named outcome, which will store whether or not the string was successfully parsed as a double
      //     A double named scoreAsDouble, which will store the parsed value
      bool outcome;
      double scoreAsDouble;

      // 2. Next, call Double.TryParse() to convert scoreAsString to a double, passing scoreAsDouble as the out argument. Save the result of the function call to the variable outcome.
      //    The signature for Double.TryParse() looks like: 
      //    public static bool TryParse (string? s, out double result);
      outcome = Double.TryParse(scoreAsString, out scoreAsDouble);
      Console.WriteLine(outcome); // True
      Console.WriteLine(scoreAsDouble); // 85.6


      // 6. Call Whisper() in the Main() method, passing statement as its string argument, then print the returned value to the console.
      //    Make sure to use an out modifier when calling the method!


      // bool marker;
      string whispered = Whisper(statement, out bool marker);  // inline 'out' variable  declaration. 
      Console.WriteLine(whispered);



    }

    // 4. Now, let’s create a method of our own that uses an out parameter!
    //    Declare a method Whisper() with a string parameter and out bool parameter. It should return a string.
    //    Whisper() should return a lowercase version of its string argument.
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }


  }
}

