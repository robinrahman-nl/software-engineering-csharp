// See https://aka.ms/new-console-template for more information

/*
If Statements
Conditional statements are one of the most common control structures in programming. They allow us to specify code that:

runs only when a condition is true
runs only when a condition is false
The most basic conditional statement is an if statement. An if statement executes a block of code if the specified condition is true.

In C#, we write an if statement using the following syntax:

string color = "blue";

if (color == "blue")
{
  // this will execute only if the value of color is equal to "blue"
  Console.WriteLine("color is blue");
}

Copy to Clipboard

If color isn’t the value "blue", the program skips over the block and moves on to the next instruction.

When writing an if statement, pay attention to:

Parentheses: We place the Boolean expression that the if statement is evaluating in parentheses ().
Braces: After the Boolean expression, we write a set of braces {}. Write the code that will execute if the Boolean expression evaluates to true inside these braces.
Indentation: While whitespace won’t impact our program, it is convention to indent the code inside the braces by two spaces.
*/

int socks = 6;


if (socks <= 3)
{
 Console.WriteLine("Time to do laundry");
}