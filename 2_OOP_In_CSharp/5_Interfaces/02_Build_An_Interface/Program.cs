/*
Build an Interface
For this lesson, we will design a new set of transportation machines that satisfy the requirements of both car designers and the highway patrol.

First, the highway patrol tells us: “Every automobile on the road must have these properties and 
methods
Preview: Docs Loading link description
 accessible to us:”

speed
license plate number
number of wheels
ability to honk
The patrol needs this information to write speeding tickets and prevent bad behavior on the highway.

In other words, the patrol makes these requirements so that it can interact with automobiles in a certain way. In C#, this group of interactions is called an interface. The interface is a set of properties, methods, and other members. They are declared with a signature, but their behaviors are not defined. A class implements an interface if it defines those properties, methods, and other members.

For example, if the patrol requires automobiles to have a license plate, then the IAutomobile interface contains a LicensePlate property. A class implements this interface if it defines a LicensePlate property.

The skeleton of an interface looks a bit like a class:

interface IAutomobile
{
}

Copy to Clipboard

Every interface should have a name starting with “I” (capital “i”, NOT lowercase “L” or number “1”). This is useful to remind other developers and our future selves that this is an interface, not a class.

We can add members, like properties and methods, to the interface. Here’s an example of a fake property and method:

interface IAutomobile
{
  string Id { get; }
  void Vroom();
}

Copy to Clipboard

Notice that the property and method bodies are not defined. An interface is a set of actions and values, but it doesn’t specify how they work. Unlike 
classes
Preview: Docs Loading link description
, the members of an interface are all public unless a different access modifier is specified.

In our highway example, the highway patrol doesn’t care how the license plate property and honk method work, they just care whether every automobile has it.

Another big difference between classes and 
interfaces
Preview: Docs Loading link description
 is that we cannot create instances of an interface. Because of this, interfaces cannot contain instance fields or constructors. These members must be defined on classes that implement the interface.

In the next exercise, we’ll learn how to implement an interface using a class.

For now, let’s start by building our own basic interface!
*/



