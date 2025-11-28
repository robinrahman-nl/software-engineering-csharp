// See https://aka.ms/new-console-template for more information
/*
Equality Operators
In programming, we often need to check whether two values are equal to each other. Have we reached the correct temperature? Is the distance to the target 0? To write statements that check these conditions, we use equality operators.

Equality 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
 allow us to create Boolean expressions that evaluate whether 2 values are equal or not equal to each other. Boolean expressions evaluate to a Boolean value. The equality operators include:

Equality operator ==: evaluates to true if the value before == is equal to the value after the operator
Inequality operator !=: evaluates to true if the 2 values are not equal
In addition to numbers, the == and != operators can be used on 
variables
Preview: Docs Loading link description
, 
strings
Preview: Docs A string is an instance of the System.String object in C# and represents an immutable sequence of Char objects.
, and boolean values:

bool answer = (true == false);
Console.WriteLine(answer); // prints False

Copy to Clipboard

The equality operators will be found in almost any real application.
*/

int cookiesSoldGuess = 250;
int storeOneCookies = 110;
int storeTwoCookies = 135;

int cookiesSoldActual = storeOneCookies + storeTwoCookies;

// (==) is the Equality Operator. 
bool guessedCorrect = (cookiesSoldGuess == cookiesSoldActual);

Console.WriteLine(guessedCorrect);


