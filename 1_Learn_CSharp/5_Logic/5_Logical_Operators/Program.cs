// See https://aka.ms/new-console-template for more information

/*
Logical Operators
We can also use 
operators
Preview: Docs Operators are used to perform various operations on variables and values.
 that take 1 or 2 Boolean values as inputs and output a single Boolean value. Logical operators, also known as Boolean operators, can be used to create Boolean expressions.

Logical operators include:

AND &&: The expression will evaluate to true only if both expressions evaluate to true. Otherwise, it will evaluate to false
OR ||: The expression will evaluate to true if at least one of the expressions evaluates to true. Otherwise, it will evaluate to false
NOT !: Evaluates to the opposite of the expression it is applied to. A true expression will evaluate to false, and a false expression will evaluate to true
Let’s look at some examples:

// (true AND true) evaluates to true
bool andExample = ((4 > 1) && (2 < 7));
// (true OR false) evaluates to true 
bool orExample = ((8 > 6) || (3 > 6)); 
// NOT (true) evaluates to false
bool notExample = !(1 < 3);

Copy to Clipboard

We can also evaluate many expressions by connecting them with logical operators:

bool answer = (9 < 3) || (100 < 45); // evaluates to false
bool another = ((3439 > 40) && (1 < 3)) || answer; // evaluates to true

Copy to Clipboard

Keep in mind that long chains of operations can be hard to read, parts of the evaluation can be stored as 
variables
Preview: Docs Loading link description
 instead.
*/

bool beach = true;
bool hiking = false;
bool city = true;

bool yourNeeds = beach && city;
bool friendNeeds = beach || hiking;

bool barcelona = beach && city;
bool tripDecision = barcelona && yourNeeds && friendNeeds;

Console.WriteLine(tripDecision);


