// See https://aka.ms/new-console-template for more information

/*
If-Else Statements
What if we want another set of instructions to execute if the condition is false? An else clause can be added to an if statement to provide code that will only be executed if the if condition is false.

When writing an if/else statement, the else statement and its code block need to follow the if statement and its code block.

We write an if/else statement using the following syntax:

string color = "red";

if (color == "blue")
{
  // This will execute only if the value of color is equivalent to "blue"
  Console.WriteLine("color is blue");
} 
else 
{
  // This will execute if the value of color isn't "blue" 
  Console.WriteLine("color is NOT blue");
}

Copy to Clipboard

In the example, we checked whether color equals "blue" again. We also added a second code block that will execute if the condition is false. Since color equals "red", the program will skip the first code block and execute the second code block before moving past the conditional statement.
*/

int people = 11;
string weather = "bad";

if (people <= 10 && weather == "nice")
{
  Console.WriteLine("SaladMart");
} else
{
    Console.WriteLine("Soup N Sandwich");
}

