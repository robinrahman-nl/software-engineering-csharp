// See https://aka.ms/new-console-template for more information

/*
Jump Statements
There are a few keywords we can use to add further control flow to our loops. Typically, they work with a series of nested loops, where one loop is written entirely within the body of another loop. These keywords are often used to limit while loops and prevent them from creating infinite loops.

break
At any point within a loop block, you can end it by using the break keyword.

int counter = 0;
// the loop definition dictates that it will continue as long as the counter is less than 10
while (counter < 10) 
{

  if (counter == 5) 
  { 
    // however, the counter will reach 5 before 10, triggering the break statement and exiting the loop 
    break; 
  } 

  counter++;
} 

// Control will move to the next block in the program

Copy to Clipboard

You’ve already seen the break keyword — it’s the same keyword that is used in switch statements.

continue
The continue keyword is used to bypass portions of a loop. It will ignore any additional code in the loop body, go back to the top, and move on to the next iteration.

for (int i = 0; i <= 10; i++)
{
  if (i < 9)
  {  
    continue;
  }
  // This will be skipped until i is no longer less than 9
  Console.WriteLine(i);
}

Copy to Clipboard

Here, the program starts in the for loop and then hits the if statement. Since there is a continue in the if statement, it will bypass the Console.WriteLine() statement until the condition in the if statement is no longer true. So even though the loop starts at 0, nothing will print to the console until i is equal to 9.

Note that in the for loop, the iteration expression is still executed after continue and before the next iteration runs. When using continue in a while loop, we must ensure that it doesn’t cause an infinite loop:

int i = 0;
while (i < 10)
{
  if (i < 9)
  {
    // we need to increment i here to prevent an infinite loop so that i does not get stuck at 0
    i++;
    continue;
  }
  // the print statement below will never be reached without incrementing i within the if statement
  Console.WriteLine(i);

  
  // if the iteration expression was instead placed here, i would always equal 0, yielding an infinite loop!
  // i++;
}

*/


bool buttonClick = false;
int count = 0;


do
{
  Console.WriteLine("BLARRRRR");
  count++;
  if (count == 3)
    {
    break;
    }

} while (!buttonClick);