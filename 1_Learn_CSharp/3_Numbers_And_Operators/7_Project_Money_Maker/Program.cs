/*
Money Maker
You have three types of coins:

A bronze coin is worth 1 cent.
A silver coin is worth 5 cents.
A gold coin is worth 10 cents.
What is the minimum number of coins that equals 98 cents?

It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project, you’ll use C# to build a Money Maker — a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:

16 bronze coins,
3 silver coins and 1 bronze coin, or
1 gold coin, 1 silver coin, 1 bronze coin
16 cents, divided in the three ways in the preceding list

For the purposes of this project, we’d want the last option because it uses the fewest coins.

This project will get you comfortable with division (/), rounding down (Math.Floor()), and modulo (%). You can find how many coins “fit” into an amount by dividing the amount by the coin value, rounding down, and finding the remainder.

Let’s walk through an example:

The user enters 15 cents. A gold coin is 10 cents, so 1.5 gold coins fit into the total.

goldCoinsIn15Cents = 15 / 10; // Equals 1.5

Copy to Clipboard

But we can’t divide coins in half, so instead, we round down to the nearest whole number:

actualGoldCoins = Math.Floor( 15 / 10 ); // Equals 1

Copy to Clipboard

We can then use the modulo operator to find the remainder of dividing the complete total by the value of a gold coin:

double remainder = 15 % 10; // Equals 5

Copy to Clipboard

Using the remainder, repeat the process with the smaller coins.

Let’s get started!

Tasks
0/12 complete
Mark the tasks as complete by checking them off
Capture Input
1.
Run the code once to understand the starting code. Type dotnet run in the terminal and press Enter or Return.

2.
Use Console.WriteLine() and Console.ReadLine() to ask the user for the amount to convert and capture the value in a variable.

3.
Convert the captured value (a string) to a number.

Since we’ll be performing division with this number, it should either be a double or a decimal. You can convert a value to these types using Convert.ToDouble() and Convert.ToDecimal() respectively.

Although these are technically “financial” values, the extra precision of the decimal type is not strictly necessary here.

4.
Before we begin calculating, let the user know what you are about to do. For example, if the user entered 16, the program should write something to the console like this:

16 cents is equal to...

Copy to Clipboard

5.
Run the code to check your work so far. At this point, you should see something like:

Welcome to Money Maker!
Enter an amount to convert to coins:

Copy to Clipboard

Once you enter a number — say, 16 — and press Enter, you should see something like:

16 cents is equal to...

Copy to Clipboard

Convert To Coins
6.
To convert to coins, we need to know the value of each type of coin! Define two variables that hold those values:

A gold coin is worth 10 cents.
A silver coin is worth 5 cents.
Don’t worry about bronze coins for now.

7.
To find the maximum number of gold coins that “fit” into the amount (e.g. one gold coin fits into 11 cents):

Divide the total amount by the value of a gold coin.
Round down to the nearest integer.
Store the result in a double variable called goldCoins.
8.
Use the modulo (%) operator to find the remaining amount, and store the result in a double variable called remainder.

9.
Find the maximum number of silver coins that “fit” into the remainder:

Divide the remainder by the value of a silver coin.
Round down to the nearest integer.
Store the result in a double variable called silverCoins.
10.
Use the modulo (%) operator to find the remaining amount and store it in the existing remainder variable.

remainder = remainder % silverValue;

Copy to Clipboard

11.
Print out all of the coins! If your input was 16, your output should look something like:

16 cents is equal to...
Gold coins: 1
Silver coins: 1
Bronze coins: 1

Copy to Clipboard

Note that we don’t need to do any extra work to find the number of bronze coins. Since each bronze coin is worth 1 cent, the number of bronze coins needed is equal to the remainder!

12.
Test the application to make sure it works! Some test cases are provided in the hint.

Here are two optional challenges:

The program doesn’t work correctly if the user enters a decimal, like 16.2 cents — it would say 1.2 bronze coins are needed, which isn’t possible! Using a Math method, round down their input to the nearest whole cent.
Use another currency with different coin amounts. For example, the US uses 1, 5, 10, and 25-cent coins called pennies, nickels, dimes, and quarters, respectively.
*/

using System;
using System.Runtime.Intrinsics.Arm;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins");
      double amountToConvert =  Math.Floor(Convert.ToDouble(Console.ReadLine()));
      Console.WriteLine($"{amountToConvert} is equal to .....");

      // To convert to coins, we need to know the value of each type of coin! Define two variables that hold those values:
      int goldCoinValue = 10;
      int silverCoinValue = 5;

      // To find the maximum number of gold coins that “fit” into the amount (e.g. one gold coin fits into 11 cents):
      double goldCoins = Math.Floor(amountToConvert / goldCoinValue);
      
      // Use the modulo (%) operator to find the remaining amount, and store the result in a double variable called remainder.
      double remainder = amountToConvert % goldCoinValue;
      
      // Find the maximum number of silver coins that “fit” into the remainder:
      double silverCoins = Math.Floor(remainder / silverCoinValue);
      
      // Use the modulo (%) operator to find the remaining amount and store it in the existing remainder variable.
      remainder = remainder % silverCoinValue;
      

      // Print out all of the coins!
      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");

    }
  }
}
