/*
Review
In this lesson, we learned that:

Classes
Preview: Docs A blueprint or template for creating objects.
 and 
interfaces
Preview: Docs An interface is an abstract contract that defines methods and properties that must be implemented by any class that implements the interface.
 are reference types. A variable of this type holds a reference to the data, not the data itself. This is different from value types like int and bool.
The equality operator (==) uses a referential comparison for reference types and a value comparison for value types.
Multiple references can be created for a single object.
A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference.
The functionality available to an object reference is determined by the reference’s type, not the object’s type.
Instructions
In Program.cs, there are two lines that are commented out:

f.Define();

Copy to Clipboard

benc3.Define();

Copy to Clipboard

Before you move on, make sure you can explain why each of them causes an error. Feel free to use this space to continue practicing what you’ve learned about references in C#!
*/

using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two references to the same object
            Encyclopedia enc1 = new Encyclopedia();
            Encyclopedia enc2 = enc1;
            enc1.CurrentPage = 31;
            enc1.Flip();
            Console.WriteLine(enc1.CurrentPage); // 32 
            Console.WriteLine(enc2.CurrentPage); // 32
                                                 // Both print 32

            // Referential equality when comparing reference types
            Encyclopedia d1 = new Encyclopedia(50);
            Encyclopedia d2 = new Encyclopedia(50);
            Console.WriteLine(d1 == d2); // False

            Encyclopedia d3 = d1;
            Console.WriteLine(d3 == d1); // True

            // Prints False

            // Value equality when comparing value types
            int int1 = 6;
            int int2 = 6;
            Console.WriteLine(int1 == int2);
            // Prints True

            // Reference to object with implemented interface
            Encyclopedia enc = new Encyclopedia(50);
            IFlippable f = enc;
            enc.Flip();
            f.Flip();
            Console.WriteLine(enc.Define());
            // This causes an error! 
            // because f is a reference of type IFlippable, and the interface does not declare a Define() method.
            // Therefore, the compiler does not allow calling Define() through f. 
            // Console.WriteLine(f.Define());

            // Reference to object with inherited superclass
            Encyclopedia enc3 = new Encyclopedia(19, "Codecademy Curriculum Team", "Codecademy Encyclopedia of Coding Knowledge");
            Book benc3 = enc3;
            Console.WriteLine(enc3.Author);
            Console.WriteLine(benc3.Author);
            Console.WriteLine(enc3.Define());
            // This causes an error!
            // benc3.Define();

            // Arrays of references
            IFlippable[] flippers = new IFlippable[] { new Encyclopedia(), new Novel() };
            foreach (IFlippable flipper in flippers)
            {
                flipper.Flip();
            }

            // Same reference type but different behavior (using virtual/override)
            Book benc = new Encyclopedia();
            Book bk = new Book();
            Console.WriteLine(benc.Stringify());
            Console.WriteLine(bk.Stringify());
            // Output:
            // "This is a Encyclopedia object!"
            // "This is a Book object!"

        }
    }
}
