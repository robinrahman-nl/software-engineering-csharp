/*
Data Types and Variables
Handling Errors
When you program, you’ll come across a lot of errors. And that’s ok! When you’re first starting to learn a strongly-typed language, errors can be rather common.

So, what happens if you forget to specify a data type for your variable?:

randomData = "asdf jskdf";
Console.WriteLine(randomData);

Copy to Clipboard

C# will give an error because it doesn’t want you to have random data being used in your application. The error will look something like this:

/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/Program.cs(9,7): error CS0103: The name 'randomData' does not exist in the current context [/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/e7-workspace.csproj] 

Copy to Clipboard

Error messages in C# are comprised of 3 primary portions, let’s break them apart so this is easier to read.

First, we have the full local path of the file where the error occurred, Program.cs. The numbers that follow in parentheses denote the line and character of the file responsible for the error, resepctively — so (9,7) indicates that the error is on line 9, beginning at the 7th character (including spaces):

/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/Program.cs(9,7):

Copy to Clipboard

Next is the actual error, which will inform us what in our code is incorrect. Every kind of error in C# has a unique identifier, like “CS0103”, so that they can easily be found within the Microsoft documentation. This error indicates that a variable name was used without ever being defined:

error CS0103: The name 'randomData' does not exist in the current context 

Copy to Clipboard

Finally, a C# program requires a special type of file using the .csproj extension, which dictates build and deploy metadata for the project. You will not need to worry about .csproj files while working within the Codecademy environment, but it will be useful to know that it is included within error messages:

[/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/e7-workspace.csproj] 

Copy to Clipboard

Let’s look at another error! If we forget to end a statement with a semicolon (;):

int score = 45

Copy to Clipboard

We will see an error like this:

/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/Program.cs(9,21): error CS1002: ; expected [/home/ccuser/workspace/csharp-data-types-variables-handling-errors-csharp_v2/e7-workspace.csproj]

Copy to Clipboard

We also need to watch out for how we name our 
variables
Preview: Docs Loading link description
 — they can only contain underscores, letters, and digits. It’s also good practice to use camelCase styling, though the compiler does not enforce this convention.

string iAmAVariable;
string i'mnot; // This will cause an error

Copy to Clipboard

There are also a few words that you can’t use. These are known as reserved keywords. Reserved keywords are words that the language uses, so they already have specific definitions that shouldn’t be rewritten. If we use one of them as a variable name, we risk overwriting it and causing significant errors in our program. For example, we can’t name a variable string because that word is reserved for defining 
data types
Preview: Docs Loading link description
.

Lastly, it’s important to double-check spelling and punctuation! Luckily, many IDEs will point out these potential errors before we even run our code, but it’s still good to be prepared to handle these errors if you should see them, including when you’re coding on Codecademy.
*/

using System;

namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = 38498.3222;

      string dinosaur = "Barney";

      double lok = 293.000;

      bool isYes = true;

      string band = "The Low Anthem";

    }
  }
}
