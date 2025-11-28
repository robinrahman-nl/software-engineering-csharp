/*
Understanding Virtual Methods and Overriding Methods
To enable Polymorphism within our class structure, we will need to create virtual methods within a base class. We can then override those 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 in the derived class. Let’s take a look at how this is done.

A virtual method is a method in the base class that can be overridden in derived 
classes
Preview: Docs Loading link description
. The virtual keyword is used to allow derived classes to provide specific implementations of this method.

public class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Animal makes a sound.");
  }
}

Copy to Clipboard

The above virtual method is defined using the virtual keyword.

Overriding Methods

Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class. The override keyword is used to indicate that a method in a derived class is intended to replace a method in the base class.

public class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Dog barks.");
  }
}

Copy to Clipboard

The above method overrides the base class’ virtual method using the override keyword.
*/

using System;

namespace PolymorphismBasics
{
  public class Employee
  {
    public void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    public void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
  }

  public class Engineer : Employee
  {
    
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Manager manager1 = new Manager();
      manager1.MakeHRRequest();

    }
  }
}