// See https://aka.ms/new-console-template for more information

/*
For Each Loop
There’s one more way to give looping instructions to a computer. We define a sequence of values and tell the computer to repeat the instructions for each item in the sequence.

foreach (type element in sequence)
{
  statement;
}

Copy to Clipboard

The foreach loop is used to iterate over collections, such as an array.

In our video game, we want to play a melody. We can do that by iterating through a list of individual notes, playing one after the other. Here’s an example array of notes:

string[] melody = { "a", "b", "c", "c", "b" };

Copy to Clipboard

and the loop would look like:

foreach (string note in melody)
{
  Console.WriteLine(note);
}

Copy to Clipboard

where writing the note to the console represents it being played.

The sequence we used was an array, but we can use other similar data structures. The umbrella term for those is “collection”, so we can also call foreach 
loops
Preview: Docs Loading link description
 collection loops.

Use this loop when you need to perform a task for every item in a list, or when the order of things must be maintained. In this case, both are important. A note must be placed for each item in the list, and the order of the notes is essential to the musical pattern.
*/

string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

foreach (string i in todo)
{
  Console.WriteLine($"[] {i}");
  
}

