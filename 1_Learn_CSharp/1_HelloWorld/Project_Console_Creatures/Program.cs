/*
Console Creatures
C# can be used to make nearly anything – even creatures! Using the Console.WriteLine() command, you can print text to the console and make something like this:

 .-.
(o o)
| O |
|   |
'~~~'

Copy to Clipboard

Each part of the creature is a line of text, using symbols like parentheses () and tildes ~. Spooky, right? These types of drawings are sometimes called ASCII art, and you can find them all across the internet.

The C# program is already set up for you in the text editor. For now, you can ignore everything except the line with Console.WriteLine();. You’ll be copying and editing this command throughout the project.

Make sure to use double quotes (") and a semicolon (;) like so:

Console.WriteLine("This will be printed to the console!");

Copy to Clipboard

Tasks
0/7 complete
Mark the tasks as complete by checking them off
Build a Creature
1.
Click the “Save” button to run the starting code.

2.
Before the first Console.WriteLine() command, write a comment explaining the purpose of this program.

3.
Since the creature head has already been created, draw the eyes: write a new Console.WriteLine() command with this text inside the parentheses:

"(o o)"

Copy to Clipboard

4.
Draw the mouth: write another Console.WriteLine() command, this time using the text:

"| O |"

Copy to Clipboard

5.
Make the body of the creature by using two more Console.WriteLine() commands and this text:

"|   |"

Copy to Clipboard

"'~~~'"

Copy to Clipboard

6.
Name your creature by adding another line of text below it.

7.
You’ve built your very own creature! You can build all kinds of characters with this technique. Find even more inspiration in the hint.

 .-.
(o o)
| O |
|   |
'~~~'

Copy to Clipboard

Remember:

The backslash \ is an escape character in C#, so \" will show up as one quote in the output (") and \\ will show up as one backslash in the output (\).
Spaces matter! " (" is not the same as "(".
*/

using System;
using System.Security.Cryptography;

namespace ConsoleCreatures
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(" .-.");
      Console.WriteLine(" o o");
      Console.WriteLine("| O |");
      Console.WriteLine("|   |");
      Console.WriteLine("'```'");
      Console.WriteLine("Code_Monster");
     }
  }
}
