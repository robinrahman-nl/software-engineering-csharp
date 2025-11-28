using System;



/*
Comparing Loops
You may have noticed that there are many similarities between different types of 
loops
Preview: Docs Loading link description
, and you’re right!

We just showed how we could use a foreach loop to iterate through an array. But we can also use a for loop to iterate through an array:

string[] items = { "potion", "dagger", "shield", "plant" };

for (int i = 0; i < items.Length; i++)
{
  Console.WriteLine(items[i]);
}

Copy to Clipboard

We could even write a complicated while loop that starts a counter at 0 and then compares that counter to the length of the items array. If the counter is less than the array length, the loop will continue. Otherwise, it will stop looping through the statements and the program will move on to the next line of code.

int i = 0;
while (i < items.Length)
{ 
  Console.WriteLine(items[i]); 
  i++; 
}

Copy to Clipboard

Since a foreach loop does the same thing as the other two but is more concise, it is less prone to errors and the better choice in this circumstance.

string[] items = { "potion", "dagger", "shield", "plant" };

foreach (string item in items)
{
  Console.WriteLine(item);
}

Copy to Clipboard

In general,

while loops are good when you know your stopping condition, but not how many times the loop will need to run.
do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
for loops are best if you want something to run a specific number of times, rather than given a certain condition.
foreach loops are the best way to loop over an array, or any other collection.
*/

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
          string[] websites = { "twitter", "facebook", "gmail" };
     
      
      foreach (string website in websites )
      { 
        Console.WriteLine(website); 
        
      }
    }
  }
}
