/*
Access Modifiers
In the 
classes
Preview: Docs Loading link description
 we’ve built so far, we used the public keyword for all of our members. It’s time to learn about what that does and what other options there are. Right now, any code outside our class can access and update our class members:

class Forest
{
  public int age;
}

public static void Main(string args[])
{
  Forest f = new Forest();
  // the age field can be accessed directly
  f.age = 32;
}

Copy to Clipboard

We can use access modifiers, such as public and private, to control where the members of a class can be accessed:

public: Any class can access a public member.
private: A private member can only be accessed by code within the same class.
For simplicity, we’ve been using public for all members so far. This allows code from the Main() method to access the members, even though Main() does not belong to our defined class. When we switch a field from public to private, it is no longer accessible from Main().

Access modifiers apply to all class members, including fields and 
methods
Preview: Docs Loading link description
.

We implement encapsulation using public and private to protect a class’s inner workings. By making fields private, we control how data is accessed and modified. This is a form of defensive coding. C# encourages encapsulation by defaulting all class members to private.
*/

using System;

namespace AccessModifiers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      f.AnnounceForest();

    f.Grow();

      f.AnnounceForest();
    }
  }
}
