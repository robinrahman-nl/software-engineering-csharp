// See https://aka.ms/new-console-template for more information

/*
Ternary Operators
Ternary 
operators
Preview: Docs Loading link description
 execute one expression if the condition is true and the second expression otherwise, similar to an if-else statement.

Here’s an example:

string color = "green";
string movement = (color == "green") ? "go" : "stop";
Console.WriteLine(movement);

Copy to Clipboard

In this example movement will be set to the result of the ternary expression. The Boolean expression (color == "green"), followed by a question mark ?, determines the outcome:

If the condition evaluates to true the ternary statement will evaluate to "go".
Otherwise, the statement will evaluate to "stop".
We separate the two possible expressions, "go" and "stop", with a colon :.

The following example is equivalent to the Ternary operator above:

string color = "green";
string movement;
if (color == "green") {
  movement = "go";
} else {
  movement = "stop";
}

Copy to Clipboard

Ternary statements can be difficult to read, so they are best used with simple expressions and conditions.
*/

int pepperLength = 4;

string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

Console.WriteLine(message);

/*
Here’s what we’ve learned about using control flow in our programs:

using if, else if, and else statements to control which code blocks execute based on conditions
writing switch statements for situations where there are many conditions
using ternary operators for shorter conditional statements
Some form of conditional statement will be used in almost any large program we write.
*/