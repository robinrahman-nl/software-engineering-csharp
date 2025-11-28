/*
Review
In this lesson on encapsulation and 
classes
Preview: Docs A blueprint or template for creating objects.
, we’ve learned how to:

use access modifiers like public and private to control where class members can be accessed
control access to and provide value validation for fields using properties
create static members, which relate to the class itself rather than its instances
create and use static classes, which are comprised entirely of static members
*/


using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. 
      // From Program.cs, print the number of forests created.
      Console.WriteLine(Forest.ForestsCreated);

      // 2. 
      // Instantiate two Forest objects.
      Forest blackForest = new Forest("Black Forest");

      Forest goldenForest = new Forest("Golden Forest");

      // 3. 
      // Print the number of forests created again. 
      // Before moving on, make sure you can explain how this value was changed.
      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}
