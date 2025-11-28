// See https://aka.ms/new-console-template for more information


/*
Building Arrays
In C#, 
arrays
Preview: Docs An array is a data structure used in C# to store a sequential collection of elements.
 are a collection of values that all share the same data type. An array of type string could hold a list of someone’s favorite songs, or an array of type int could store a collection of user IDs.

Similar to defining a variable for one piece of data, when we define a variable to hold an array, we also have to specify the type:

// These arrays store ints, strings, and doubles, respectively
int[] x; 
string[] s; 
double[] d; 

Copy to Clipboard

To declare a variable that holds an array, we first write the type of data that will be stored in an array, then add the square brackets ([]) to signify that it is holding an array (rather than a single value), followed by the name of the array.

Like a variable, we can define and initialize an array at the same time, by specifying the values we want to store in it:

int[] plantHeights = { 3, 4, 6 };

Copy to Clipboard

To declare and initialize an array at the same time, we begin with the variable declaration syntax followed by an equal sign and the values of the array, separated by commas , and enclosed in curly braces ({}).

You may also see arrays defined and initialized using the new keyword:

int[] plantHeights = new int[] { 3, 4, 6 };

Copy to Clipboard

The new keyword signifies that we are instantiating a new array from the array class. We’ll cover 
classes
Preview: Docs Loading link description
 and instantiation in another lesson, but for now, we can just think of it as another way to create an array.

In fact, if we decide to declare an array and then initialize it later, rather than in one line like above, the new keyword must be used:

// Initial declaration
int[] plantHeights;

// This will cause an error
// plantHeights = { 3, 4, 6 }; 

// This will work
plantHeights = new int[] { 3, 4, 6 };   
*/

