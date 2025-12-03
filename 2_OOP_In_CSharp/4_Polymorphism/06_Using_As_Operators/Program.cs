/*
Using 'is' Operators
In C#, the is operator checks if an object is compatible with a given type.

The result of the is operator is true if an object can be upcast or downcast to a specified type and false if it can not. This can be a useful check before performing these casting operations.

Example:

class Program
{
  static void Main(string[] args)
  {
    // Create an Animal reference pointing to a Dog object
    Animal myAnimal = new Dog();

    // Use the 'is' operator to check if the Animal reference can be cast to a Dog
    if (myAnimal is Dog)
    {
      Console.WriteLine("This is a Dog.");
    }

    // Use the 'is' operator to check if the Animal reference can be cast to a Cat
    if (myAnimal is Cat)
    {
      Console.WriteLine("This is a Cat.");
    }
      else
    {
      Console.WriteLine("This is not a Cat.");
    }
  }
}

Copy to Clipboard

In the above example:

The is operator checks if myAnimal can be cast to type Dog and prints a message if true.
The is operator checks if myAnimal can be cast to type Cat and prints a message if false.
These checks allow us to safely cast, whether it is upcasting or downcasting.
*/

using System;
using System.Net.Http.Headers;

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
      Employee myEmployee = new Engineer(); // shortcut upcasting       
      
      // 2. 
      // Now inside a Console.WriteLine() statement, output the result of using the is operator to check if myEmployee can be cast to an Engineer.
      Console.WriteLine(myEmployee is Engineer); // True

      // 3. 
      // Inside another Console.WriteLine() statement, output the result of using the is operator to check if myEmployee can be cast to a Manager.
      Console.WriteLine(myEmployee is Manager); // False 
    }
  }
}


