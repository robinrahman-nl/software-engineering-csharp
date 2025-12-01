/*
Upcasting Objects
In some cases, we may want to create an instance of our base class with access to the overridden 
methods
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
 of a derived class. This is where we would use upcasting.

Upcasting in C# refers to converting a derived class instance to a base class instance. To upcast, we assign a derived instance to a variable with the base class type.

BaseClass upcastInstance = derivedInstance;

Copy to Clipboard

The upcasting is implicit, which means it happens automatically with no extra syntax.

An instance that has been upcast to a base class instance will have access to the following:

The derived class’s overridden methods.
The base class’s non-virtual methods.
It is important to note that any method in the derived class that does not override a method in the base class will not be accessible from an upcast instance. Let’s explore upcasting with an example.

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
    // Create a Dog object
    Dog myDog = new Dog();

    // Upcast the Dog object to an Animal reference
    Animal myAnimal = myDog;

    myAnimal.MakeSound(); // Output: Dog barks.
    myAnimal.Walk(); // Output: Animal walks.
    myAnimal.Sleep(); // Output: ERROR
  }
}

Copy to Clipboard

A Dog object is created and assigned to the myDog variable. The myDog object is then upcast to an Animal reference and assigned to the myAnimal variable.

Let’s observe the behavior of the upcasted object:

When myAnimal.MakeSound() is called, the overridden method in the Dog class is executed.
When myAnimal.Walk() is called, the method in the Animal class is executed.
When myAnimal.Sleep() is called, an error occurs because it is a non-overridden method in the Dog class.
*/

using System;

namespace PolymorphismBasics
{
  public class Employee
  {
    // Virtual method in the base class
    public virtual void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  public class Engineer : Employee
  {
    // Override the virtual method in the derived class
    public override void MakeHRRequest()
    {
      Console.WriteLine("Engineer makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    // Override the virtual method in the derived class
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      // Your code below
      Manager myManager = new Manager();

      // 2. 
      // In the Program class, upcast the Manager object myManager to an Employee reference named myEmployeeManager.
      Employee myEmployeeManager = myManager;
      myEmployeeManager.MakeHRRequest();
      

    }
  }
}
