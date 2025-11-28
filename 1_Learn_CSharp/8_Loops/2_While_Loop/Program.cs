// See https://aka.ms/new-console-template for more information

/*
While Loop
Loops
Preview: Docs A loop is a logical structure that allows for the repeated execution of a block of code.
 are used to repeat a set of instructions based on a set of conditions. If this makes you think of conditional statements, you’re not wrong!

The while loop looks very similar to an if statement. Just like an if statement, it executes the code inside of it if the condition, a statement that evaluates to a boolean value, is true.

while (condition) 
{
  statement;
}

Copy to Clipboard

However, unlike an if statement that runs once, a while loop will continue to execute the code inside of it, over and over again, while the condition is true. The computer constantly checks to see if the condition is satisfied. For this reason, while loops are useful when you know at what point a program should stop rather than the number of times it should repeat.

In your video game, you want the player to rise up in the air as long as the user is pressing the spacebar:

while (spacebar == "down") 
{
 RiseUp();
}

Copy to Clipboard

In this example, while spacebar is equal to down, the character will keep rising on the screen. It will exit the while loop once the user releases the spacebar, and then the rest of the program will continue.

while loops can get dangerous because they depend on that condition to return false at some point. What if we never take our finger off the spacebar? Sounds ridiculous, but theoretically, the program would run forever! This is known as an infinite loop. If you find yourself stuck in an infinite loop on Codecademy, you can stop it by reloading the page.
*/

int emails = 20;

while (emails > 0)
{
  emails--;
  Console.WriteLine($"deleted 1 email. there are {emails} emails left.");
}


    Console.WriteLine("INBOX ZERO ACHIEVED!");


