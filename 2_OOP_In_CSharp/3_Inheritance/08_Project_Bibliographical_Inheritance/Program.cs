/*
Bibliographical Inheritance
At the Codecademy Central Library, there is an effort underway to digitize existing systems in order to more easily track and update collections. The main categories of media to be managed include: books, periodicals, and videos. In this project, you’ll be developing a system in C# to track the availability and the descriptive information of these resources.

Books have title, author, page count, category, and status values.
Periodicals have title, period, category, and status values.
Videos have title, director, length, category, media type, and status values.
Notice anything shared between these resource types? If we created completely separate classes for each type of media, we would have a lot of duplicated code. Instead, we’ll create a base class containing the fields that every resource has: title, category, and status. Then, we can create subclasses to represent each type of resource, adding their unique fields.

Let’s get started!

Tasks
0/19 complete
Mark the tasks as complete by checking them off
Resource
1.
First, we’ll define the Resource class, which will serve as our “base” or “super” class.

In Resource.cs, define the class with the following members:

A string Title property, with a public getter and private setter. This represents the name of the resource.
A string Category property, with a public getter and private setter. This represents the genre or type of resource.
A string Status property, with a public getter and protected setter. This is a flag that will track the availability of the resource.
A constructor that takes two parameters, one that sets the Title property and another that sets the Category. The constructor should also set Status to "Available" by default.
2.
Resource needs a method for updating the status of an item.

Add an UpdateStatus() method that switches the status to reflect the opposing status, "Out". If Status is already "Out", it should be switched back to "Available". The method will not return a value.

3.
Finally, we want a method that will quickly print out all of the relevant resource details.

This method, GetInfo(), should use string interpolation to return each of the 3 resource fields defined on a separate line using the following format — “Title: Example Title”. GetInfo() will not return a value.

4.
Test your class! In Program.cs, construct a new Resource named test.

After constructing a new object, call the GetInfo() method. Additionally, call the UpdateStatus() method and print the value of test.Status.

Book
5.
Next we’ll define Book, our first derived class, which inherits from Resource. In addition to the elements previously defined in Resource, we’ll add Author and PageCount properties to our new Book class.

In Book.cs, define an empty Book class that inherits from Resource.

6.
Give the Book class Author and PageCount properties, of types string and int, respectively.

7.
Add a Book constructor that takes three string parameters and one int. It should call the base constructor with the values corresponding to Title and Category, then directly set the Author and PageCount properties with the other values.

8.
Test your class! In Program.cs, construct a new Book named "Code: The Hidden Language of Computer Hardware and Software". The other fields include:

Author: Charles Petzold
Genre: Non-Fiction
Pages: 396
After constructing this new object, call GetInfo().

Periodical
9.
Our second derived class will be Periodical.

In Periodical.cs, create an empty class named Periodical.

10.
This class will be similar to the one constructed for books, in that it will add a property and contain a modified version of the previous constructor. Additionally, we will override the UpdateStatus() method to address how periodicals are used in the library.

Begin by creating the new string property Period, which will store the publishing frequency of the given journal or magazine.

11.
Next, define a constructor that takes three arguments, one for each property.

Pass the values for the Title and Category to the base constructor, then in the body of the Periodical constructor, set the value for the new Period property.

12.
Finally, the UpdateStatus() method should be overridden to reflect that periodicals are used only within the library. Therefore, the "Out" status will be replaced with "In-use".

In Resource.cs, change the base UpdateStatus() method to a virtual method so that it can be overridden.

In Periodical.cs, redefine the UpdateStatus() method to reflect the appropriate statuses for periodicals. Don’t forget to use the override keyword!

13.
Test your class! In Program.cs in Main(), construct a new Periodical as p. It should contain:

Title: "Wired"
Category: "Technology"
Period: "Monthly"
After constructing the new object, call UpdateStatus(), then print p.Status.

Video
14.
Finally, for the videos in our collection, we will need a class that also has Director, RunTime and MediaType properties.

In Video.cs, define an empty Video class that inherits from Resource.

15.
Add each of the three new properties to Video.cs:

Director, a string representing the director’s name
Runtime, the movie length in minutes as an integer
MediaType, a flag that will designate if the given video is "On-demand" or a "DVD"
16.
Add a Video constructor with four string arguments and one int argument. Pass the values corresponding with the Title and Category properties to the base constructor, then directly set the Director, RunTime, and MediaType.

17.
Now, we want to expand the GetInfo() method for Video so that it prints additional data, like the Director and RunTime.

In Resource.cs, change the base GetInfo() method to a virtual method so that it can be overridden.

In Video.cs, redefine the UpdateStatus() method so that it includes video-specific properties.

18.
Test your class! In Program.cs, construct a new Video as v with the following details:

Title: "Ex Machina"
Director: "Alex Garland"
Category: "Sci-Fi"
RunTime: 108
MediaType: "On-Demand"
Then, call GetInfo() on the new object.

Extensions
19.
Well done! You’ve created four new classes. Three of them are derived classes and each class has new properties and updated methods.

If you’d like more practice, try these optional challenges:

In Book.cs, store the Author as an array so that we can easily accommodate multiple authors. What additional changes would we need to easily retrieve the authors from a cataloged resource?
In Resource.cs, add a string[] Holds property so that people can be added to a waitlist for resources that are already checked out. Then, add methods to remove or add holds each time the respective method is called.
*/

using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    { 
      // Test 1: 
      Resource foundation = new Resource("Foundation", "Sci-Fi");
      foundation.UpdateStatus();
      foundation.GetInfo();
      

      // Test 2:

      Book book1 = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", new string[] {"Pritzel", "Robin"}, 396);
      book1.GetInfo();

      // 13. Test your class! In Program.cs in Main(), construct a new Periodical as p. 
      // It should contain: Title: "Wired" Category: "Technology" Period: "Monthly" 
      // After constructing the new object, call UpdateStatus(), then print p.Status.

      Periodical p = new Periodical("Wired", "Technology", "Monthly");
      p.UpdateStatus();
      p.GetInfo();

      Video v = new Video("Ex Machina", "Alex Garland", "Sci-Fi", "on-Demand", 108);
      v.GetInfo();



    }
  }
}