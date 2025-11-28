// See https://aka.ms/new-console-template for more information

/*
Comparison Operators
When writing a program, we often need to compare two values relative to each other.

Like equality operators, comparison operators allow us to create Boolean expressions, but instead of equality, they evaluate 2 values and the relationship between them. Comparison operators include:

Less than <: evaluates to true if the first value is less than the second value
Greater than >: evaluates to true if the first value is greater than the value to the right
Less than or equal to <=: evaluates to true if the first value is less than or equal to the second value
Greater than or equal to >=: evaluates to true if the first value is greater than or equal to the second value
Here’s an example of using comparison operators:

bool isLess = 3 < 75; 
Console.WriteLine(isLess); // prints True
int value = 10;
bool isGreater = value > 20;
Console.WriteLine(isGreater); // prints False

Copy to Clipboard

We will often use comparison operators when we use if or looping statements, both of which are covered later in the course.
*/

double timeToDinner = 4;
double distance = 95;
double rate = 30;

double tripDuration = distance / rate;
bool answer = tripDuration <= timeToDinner;

Console.WriteLine(answer);