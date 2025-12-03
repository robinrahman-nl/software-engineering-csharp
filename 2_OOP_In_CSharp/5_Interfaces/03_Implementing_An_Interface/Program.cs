/*
Implementing an Interface
Our interface is complete! Pretty easy, right?

As we design our automobile-like 
classes
Preview: Docs A blueprint or template for creating objects.
, we’ll need to implement this IAutomobile interface. In C#, we must first clearly announce that a class implements an interface using the colon syntax:

class Sedan : IAutomobile
{
}

Copy to Clipboard

This empty Sedan class “promises” to implement the IAutomobile interface. In other words, it must have the properties and 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 the highway patrol asked for (Speed, LicensePlate, Wheels, and Honk()).

If we don’t, we get a type error like this:

error CS0535: Sedan does not implement interface member 'IAutomobile.LicensePlate'

Copy to Clipboard

To fix this, we’ll need to define the members in the interface:

class Sedan : IAutomobile
{
  public string LicensePlate
  { get; }
  
  // And so on...
}

Copy to Clipboard

Since all of the members defined on our interface are public, the members defined by the Sedan class must also be public. Since these are class members, they will be private by default, so we must specify the access modifier.

So, Sedan needs to satisfy the highway patrol’s rules (the IAutomobile interface). But that’s not all — the car designers have asked that sedans be built in and move in certain ways. So it will have constructors and methods that aren’t required by the IAutomobile interface. This is okay in C#! An interface says what a class must have. It does not say what a class must not have. A class in C# can even implement multiple 
interfaces
Preview: Docs Loading link description
 by separating the interface names with a comma:

class Cat : IQuadruped, IFeline
{  
  // member implementation for both IQuadruped and IFeline
}
*/

