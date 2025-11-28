// See https://aka.ms/new-console-template for more information




string designer = "Anders Hejlsberg";

// 1. Call Console.WriteLine() using designer as an argument.
Console.WriteLine(designer); // Anders Hejlsberg

// 2. Now, let’s print only Anders’ second name. First, find the index of the space (" ") in the string designer and store it in a variable indexOfSpace. You’ll need to use the IndexOf() method.
int indexOfSpace = designer.IndexOf(" ");
Console.WriteLine(indexOfSpace); // 6

int indexOfSecondName = indexOfSpace + 1;
Console.WriteLine(indexOfSecondName); //7

string secondName = designer.Substring(indexOfSecondName);
Console.WriteLine(secondName); // Hejlsberg