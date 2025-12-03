/*
Using 'as' Operators
In C#, the as operator attempts to cast an object to a given type, returning null if the cast fails. This is useful for safely trying to downcast an object to a more derived type without risking an exception.

If you have not encountered null until now, it represents an uninitialized state of a reference. With null as an option, we can now cast and check after the fact if it was successful. Let’s look at an example:

class Program
{
  static void Main(string[] args)
  {
    // Create an Animal reference pointing to a Dog object
    Animal myAnimal = new Dog();

    // Use the 'as' operator to attempt to cast the Animal reference to a Dog
    Dog myDog = myAnimal as Dog;
    
    if (myDog != null)
    {
      myDog.Fetch();
    }

    // Use the 'as' operator to attempt to cast the Animal reference to a Cat
    Cat myCat = myAnimal as Cat;
    
    if (myCat == null)
    {
      Console.WriteLine("Downcasting failed using 'as' operator.");
    }
  }
}

Copy to Clipboard

In the above example:

The as operator attempts to cast myAnimal to a Dog and calls the Fetch() method if successful.
The as operator attempts to cast myAnimal to a Cat and prints a message if the cast fails.
It is important to note that the as operator can be used to upcast as well, but it is more common to use the implicit assignment statement when upcasting.
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

    public void SubmitPR()
    {
      Console.WriteLine("Engineer submits a pull request.");
    }
  }

  class Manager : Employee
  {
    // Override the virtual method in the derived class
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
      Employee myEmployeeEngineer1 = new Engineer();  // Engineer types upcast to Employee types.
      Employee myEmployeeEngineer2 = new Engineer(); // Engineer types upcast to Employee types.
      // Your code below


    Engineer engineer = myEmployeeEngineer1 as Engineer;   // set engineer to myEmployeeEngineer1 downcast to the Engineer type.

    // Output the value of engineer == null to the console.
    Console.WriteLine(engineer == null); // False

    // 2. 
    // Now define a variable named manager of type Manager. Using the as operator, set manager to myEmployeeEngineer2 downcast to the Manager type.
    Manager manager = myEmployeeEngineer2 as Manager;

    // Output the value of manager == null to the console.
    Console.WriteLine(manager == null); // True . because myEmplyeeEngineer2 was never a manager object / reference.

    

/*

1.
In the Main method, there are two variables, myEmployeeEngineer1 and myEmployeeEngineer2. They are both Engineer types upcast to Employee types.

Define a variable named engineer of type Engineer. Using the as operator, set engineer to myEmployeeEngineer1 downcast to the Engineer type.

Output the value of engineer == null to the console.

You might see a warning output followed by the result of engineer == null. The warning is in response to a potential null value and you can ignore it.

Checkpoint 2 Passed
2.
Now define a variable named manager of type Manager. Using the as operator, set manager to myEmployeeEngineer2 downcast to the Manager type.

Output the value of manager == null to the console.
*/


    
      



    }
  }
}

