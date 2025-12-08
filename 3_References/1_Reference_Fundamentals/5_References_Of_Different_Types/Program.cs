/*
References of Different Types
Object-oriented programming can make using references more complex.

In our previous example, both references to the Encyclopedia object were of type Encyclopedia:

Encyclopedia enc1 = new Encyclopedia();
Encyclopedia enc2 = enc1;

Copy to Clipboard

In addition to referencing an instance with its class name, it can also be referenced using the name of any type in its 
inheritance
Preview: Docs Loading link description
 hierarchy or of any interface it implements. Encyclopedia inherits from the base class Book and implements the interface IFlippable.

class Encyclopedia: Book, IFlippable {
    //...
}

Copy to Clipboard

This means we can reference Encyclopedia objects as either Book or IFlippable:

Encyclopedia enc = new Encyclopedia();
IFlippable fEnc = enc;
Book bEnc = enc;

Copy to Clipboard

Now enc, fEnc, and bEnc all refer to the same object.

A reference only has access to members of the type it is defined as. fEnc can only access members in the IFlippable interface, and bEnc can only access members in the Book superclass.
*/

using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. 
            // The code in the editor creates an Encyclopedia variable named enc, 
            // then creates references to the same object of types IFlippable and Book called fEnc and bEnc, respectively.
            // But there are 2 errors due to fEnc and bEnc attempting to access members that are not defined on their respective types!
            Encyclopedia enc = new Encyclopedia();
            IFlippable fEnc = enc;
            Book bEnc = enc;
            fEnc.CurrentPage = 42;  // works because fEnc is IFlippable type and has acces to member CurrentPage
            // bEnc.CurrentPage = 43;  // doesnt work because bEnc is an reference of Book Type and does not has acces to the member CurrentPage
            // fEnc.Stringify(); 
            bEnc.Stringify();
            Console.WriteLine(fEnc == bEnc);
        }
    }
}
