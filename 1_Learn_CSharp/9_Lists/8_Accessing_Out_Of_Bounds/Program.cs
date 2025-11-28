// See https://aka.ms/new-console-template for more information

/*
Accessing Out of Bounds
Effectively, we can add an infinite number of items to a list:

List<int> numbers = new List<int>();

for (int i = 0 ; i < 1000; i++)
{
  numbers.Add(i);
}

Copy to Clipboard

We can access and edit them using bracket notation:

int numberFive = numbers[4];
numbers[4] = 523;

Copy to Clipboard

This doesn’t mean that we can access any random index. If we try to access the 1001st element in this list, we’ll get an error:

Console.WriteLine(numbers[1001]);

Copy to Clipboard

The above code causes the error:

Unhandled Exception:
System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.

Copy to Clipboard

We can only access indices that have been added to the list. The last available index in the numbers list would be 999.

Here are two tips to avoid this issue:

Imagine the list growing every time we add a number and shrinking every time we remove a number. Unlike 
arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
, there is no set length.
Check the Count of a list before accessing an index, as shown below.
int index = 1001;
if (index < numbers.Count)
{
  Console.WriteLine(numbers[index])
}

*/


/*  List<int> numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
  numbers.Add(i);
}

int numberFive = numbers[4];
Console.WriteLine(numberFive); // 4

numberFive = 523;
Console.WriteLine(numberFive);  // 523
Console.WriteLine(string.Join(" .", numbers)); // [0 .1 .2 .3 .4 .5 .6 .7 .8 .9]
Console.WriteLine(numbers[4]); // 4

numbers[4] = 523;
Console.WriteLine(numbers[4]); // 523
Console.WriteLine(string.Join(" .", numbers)); // [0 .1 .2 .3 .523 .5 .6 .7 .8 .9]
*/


List<int> numbers = new List<int>();
for (int i = 0; i < 10; i++)
{
  numbers.Add(i);
}

// int numberFive = numbers[4];

numbers[4] = 523;
Console.WriteLine(numbers[4]);  // 523
Console.WriteLine(string.Join(" .", numbers)); // [0 .1 .2 .3 .4 .5 .6 .7 .8 .9]

// Console.WriteLine(numbers[1001]);  // Throws an Error. The program stops. 


int index_2 = 1001;
if (index_2 < numbers.Count)
{
  Console.WriteLine(numbers[1001]);
}
else
{
  Console.WriteLine($"{index_2} is Out of the bound of numbers List ");
}

/*
############################################################################################################################################################
*/

     List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      
      double futureWinner = marathons[1];
marathons[1] = 143.23;

int index = 1;
if (index < marathons.Count && index >= 0)
{
    Console.WriteLine(futureWinner);
}
      
      Console.WriteLine($"If you reached this point, there are no errors!");
