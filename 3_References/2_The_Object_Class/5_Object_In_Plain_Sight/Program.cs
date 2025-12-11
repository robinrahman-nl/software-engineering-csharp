/*
Object in Plain Sight
At the very beginning of your C# journey, we learned about Console.WriteLine(). We’ve used this tool with nearly every type, from int and bool to Encyclopedia and Novel:

bool b = true;
Novel n = new Novel();
Console.WriteLine(b);
Console.WriteLine(n);

Copy to Clipboard

We can use this same tool with every type because every type inherits from Object!

Under the hood, Console.WriteLine() uses ToString(), which is defined in Object. Every object needs some kind of string representation to be printed in text. These two lines are equivalent:

Console.WriteLine(b);
Console.WriteLine(b.ToString());
*/


using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
        // 1. 
        // Let’s prove that ToString() is used when printing to the console.
        //  First, override the ToString() method in the Novel class. Have the method return the string "Surprise!".
        
        // 2. 
        // Back in Program.cs, construct a Novel object and pass it directly to Console.WriteLine().
        // We should see the surprise printed!

        Novel n1 = new Novel();
        Console.WriteLine(n1);
               
    }
  }
}
