
/*
Abstraction
Defining Classes
C# provides a number of built-in 
classes
Preview: Docs Loading link description
 (or types), such as string:

string name = "Jacky";
Console.WriteLine(name.Length);
Console.WriteLine(name.IndexOf("k"));

Copy to Clipboard

In this case, name is an instance of the string type. Every string has a Length attribute and an IndexOf() method, but the values are independent for each instance.

To define custom classes, we can use this syntax:

class Gear 
{

}

Copy to Clipboard

The code for a class is usually put into a file named with the name of the class. In this case, the file name would be Gear.cs.

Once defined, we can create instances, or objects, of that class using the new keyword. The process of creating an instance of a class is called instantiation.

Gear g = new Gear();

Copy to Clipboard

Here, we could say g is an instance, or an object of the Gear class, or g is of type Gear. Right now, our Gear class does not have any data associated with it — we’ll change that in the next exercise!
*/

using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 2. In Program.cs, within Main(), a Forest object has already been instantiated. Set values for each of the 4 fields.
            Forest f = new Forest();
            f.name = "Amazon";
            f.biome = "Rainforest";

            f.trees = 10;
            f.age = 100;

            Console.WriteLine(f.name);
        }
    }
}


