/*
Corporate Polymorphism
Welcome to TechCorp, a rapidly growing technology company facing the challenge of managing diverse employee roles efficiently. As TechCorp expands, the HR department needs a robust application to streamline interactions with various employee types, such as Engineers, Managers, and Interns.

Imagine Engineers submitting technical requests, Managers handling project oversight, and Interns needing guidance—all while the HR team struggles to keep up. To solve this, TechCorp’s development team will leverage polymorphism in C# to create a flexible and maintainable application.

Your Mission: Join the TechCorp development team to build this application. You’ll define abstract classes, implement abstract methods, and demonstrate polymorphism through method overriding and type casting. By completing this project, you’ll gain a deeper understanding of polymorphism and its application in creating adaptable and efficient software solutions in a corporate setting.

Tasks
0/14 complete
Mark the tasks as complete by checking them off
Setting Up the Employee Class
1.
At TechCorp, the Employee class represents the common interface for all employees. By making it abstract, we ensure that specific employee types like Engineers and Managers implement their own unique behaviors.

In the Employee.cs file:

Create an abstract class named Employee.
2.
Add Methods to the Employee Abstract Class

Inside the Employee class:

Define an abstract method SubmitDailyReport() that is public and has no return type.
Define a virtual method Work() that is public and has no return type. Provide a default implementation that prints “Employee is working.”
Define a concrete method ClockIn() that prints “Employee clocks in.”
3.
The project files have an existing HR class in a file named HR.cs.

public class HR : Employee
{
  public override void SubmitDailyReport()
  {
    Console.WriteLine("HR submits daily report.");
  }

  public override void Work()
  {
    Console.WriteLine("HR handles employee matters.");
  }
}

Copy to Clipboard

Test the Employee class by using the HR employee type calls in the Main method of the Program.cs file, and the HR class.

Click the Save button to save your code and run the program.

The expected output is:

Employee clocks in.
HR handles employee matters.
HR submits daily report.

Copy to Clipboard

Setting Up the Employee Type Classes
4.
Engineers at TechCorp perform technical tasks. On a daily basis, they will need to submit a report on work performed.

In the Engineer.cs file:

Create a class named Engineer that inherits from Employee.
Implement the SubmitDailyReport() method to print “Engineer submits daily report.”.
Implement the Work() method as well. Print “Engineer works on a project.”.
Be sure both methods override the abstract methods in Employee.

5.
Upcasting allows us to treat specific employee instances as general Employee types, enabling uniform management.

In the Program.cs file Main() method:

Define a variable employee1 of type Employee and set it to an upcast instance of Engineer.
Call SubmitDailyReport() using the new variable.
Click the Save button to test.

6.
Manager and Intern roles at TechCorp will also need to be part of our employee hierarchy.

In the Manager.cs file create a class named Manager that inherits from Employee.

In the Intern.cs file create a class named Intern that inherits from Employee.

Implement the Work() method for both classes:

For Manager, print “Manager oversees the project.”
For Intern, print “Intern assists with the project.”
7.
In the Main() method:

Create instances of Manager and Intern and upcast them to variables employee2 and employee3 of type Employee.
Call the ClockIn(), Work() and SubmitDailyReport() methods on the 2 new Employee references.
Test the updates by clicking the Save button.

8.
You’ve received an error! Let’s take a look at how we can correct this by reading the first error.

error CS0534: 'Manager' does not implement inherited abstract member 'Employee.SubmitDailyReport()'
error CS0534: 'Intern' does not implement inherited abstract member 'Employee.SubmitDailyReport()'

Copy to Clipboard

It looks like we need to update our Manager and Intern classes with an override SubmitDailyReport() method:

Implement a SubmitDailyReport() method to the Manager and Intern classes, being sure to override the abstract method in each. Present the following messages for each class’ SubmitDailyReport() method:

Manager: “Manager submits daily report.”
Intern: “Intern submits daily report.”
9.
Now we can run the code without an error.

Test the updates by clicking the Save button.
Demonstrating Polymorphism
10.
Downcasting allows us to convert a general Employee reference back to a specific type, enabling access to specific methods.

In the Main() method:

Use the as operator to downcast the employee1 reference back to its original type Engineer.
Save the result of the downcast in a variable of type Engineer named engineer1.
Use an if-else to test if engineer1 is not null.
If true call SubmitDailyReport() with engineer1.
else output that the downcast failed.
Test the downcast by clicking the Save button.

11.
Creating a list of Employee objects allows us to manage and iterate over different employee types in a uniform way.

In the Main() method:

Create a list of Employee objects.
Add the variables compatible with the Employee type to the list.
12.
Iterating through the list of Employee objects and acting on each one demonstrates how polymorphism allows us to treat different employee types uniformly.

In the Main() method:

Iterate through the list of Employee objects. Use a foreach loop to accomplish this task.
Call the ClockIn(), Work(), and SubmitDailyReport() methods on each object.
Test by clicking the Save button.

13.
The is operator allows us to check the type of an object at runtime, helping in making decisions based on the actual type of the object.

In the employees loop in the Main() method:

Use if-else if and the is operator to check if each object in the list can be cast to Engineer, Intern, and Manager.
Inside if-else if output a message indicating the type of the object, such as: “This is an Engineer.”
Test the updates by clicking Save.

14.
Great work! You’ve created a class hierarchy that implements many elements of Polymorphism using what you know about C# and object-oriented programming.

Feel free to expand the hierarchy by adding more abstract or virtual methods and implementing them in the derived classes.
*/

using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    { 
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee hrRep = new HR(); // Upcasting 

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break
      //*********************************
      //******* Task3 Test Code *********
      //*********************************

      // Placeholder for list of employees

      // Placeholder for adding employees to the list
    }
  }
}
