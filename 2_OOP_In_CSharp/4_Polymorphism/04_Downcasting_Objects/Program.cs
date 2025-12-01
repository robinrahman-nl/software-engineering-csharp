/*
Downcasting Objects
Downcasting in C# refers to converting an upcast instance to a derived one. This process allows us to access the derived class members that are unavailable in the base class.

Downcasting can fail if the objects are not compatible, so it must be done carefully. Downcasting is an explicit operation and requires extra syntax:

BaseClass upcastInstance = new DerivedClass() 
DerivedClass downcastInstance = (DerivedClass)upcastInstance;

Copy to Clipboard

In the above example, an upcast instance is created. To downcast, an explicit use of the derived class type is placed before the upcast instance. This gives the downcastInstance access to both the BaseClass and the DerivedClass 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
.

Let’s explore downcasting with an example:

class Animal {
  public void Walk() {
    Console.WriteLine("Animal walks.");
  } 
  
  public virtual void MakeSound() {
    Console.WriteLine("Animal makes noise.");
  } 
}

class Dog : Animal {
  public void Sleep() {
    Console.WriteLine("Dog sleeps.");
  } 
  
  public override void MakeSound() {
    Console.WriteLine("Dog barks.");
  } 
}

class Program {
  static void Main(string[] args) {
    // Create an upcast Animal object
    Animal myAnimal = new Dog();

    // Downcast the myAnimal object
    Dog myDog = (Dog)myAnimal;

    myDog.MakeSound(); // Output: Dog barks.
    myDog.Walk(); // Output: Animal walks.
    myDog.Sleep(); // Output: Dog sleeps.
  }
}

Copy to Clipboard

A Dog object is created and upcast to the myAnimal variable of type Animal. The myAnimal reference is then downcast to a Dog reference and assigned to the myDog variable. myDog can now call the MakeSound(), Walk(), and Sleep() methods.
*/

using System;
using System.Text.Json.Serialization.Metadata;

namespace PolymorphismBasics
{
  public class Employee
  {
    public virtual void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
            
    public void MoveToOffice()
    {
      Console.WriteLine("Manager moves to office.");
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Employee myEmployeeManager = new Manager(); // upcasting // baseclass upcastinstance = derived class ( shorthand) 

      // myEmployeeManager.MoveToOffice(); // Error. want MovetoOffice method is not present in baseclass. upcasting limits acces to methods. 
      // Your code below
      Manager myManager = (Manager)myEmployeeManager; // downcasting // derivedclass downcastinstance = (derivedclass)upclassinstance. //  
      myManager.MoveToOffice();
    }
  }
}