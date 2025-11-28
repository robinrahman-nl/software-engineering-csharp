// See https://aka.ms/new-console-template for more information

/*
Else If Statements
What if we want to handle multiple conditions where something different happens for each condition? We can chain conditional statements by combining if and else statements into else if.

After an initial if statement, one or more else if blocks can check additional conditions. We can add an optional else block at the end to catch cases that do not match any of the conditions.

In C#, we write an else if statement using the following syntax:

string color = "red";

if (color == "blue")
{
  // this code block will execute only if the value of color is equivalent to "blue"
  Console.WriteLine("color is blue");
} 
else if (color == "red")
{
  // this code block will execute if the value of color is equivalent to "red"
  Console.WriteLine("color is red");
} 
else
{
  // this code block will execute if the value of color is NOT equivalent to "blue" OR "red"
  Console.WriteLine("color is NOT blue OR red");
}

Copy to Clipboard

Depending on what color is equivalent to, it will execute the corresponding code block. If color isn’t "blue" or "red", it will execute the else block before moving on to the rest of the program.

When using else if statements, each else if statement has a condition. Like an if statement, this condition goes in parentheses, and if true, the program will execute the associated code block.
*/

double ph = 7.0;
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
;
