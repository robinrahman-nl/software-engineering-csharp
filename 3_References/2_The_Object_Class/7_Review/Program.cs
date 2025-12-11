/*
Review
Good job! In this lesson you learned that:

Every type ultimately inherits from Object.
Important members of Object include: Equals(), ToString(), and GetType().
The ToString() method allows Console.WriteLine() to work for all types.
Instructions
Make sure you understand the code in the workspace before moving forward — feel free to put what you’ve learned into practice!
*/

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
      Novel nl = new Novel(38);
      Random rand = new Random();
      int i = 9;

      Object[] objects = {bk, nl, rand, i};

      foreach (Object obj in objects)
      {
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj);
      }

      bool b = true;
      Console.WriteLine(b);
      Console.WriteLine(b.ToString());
    }
  }
}
