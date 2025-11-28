using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      // Instantiate a new object with the name "Amazon". Store the result in a variable.

      Forest Amazon = new Forest("Amazon");
      Console.WriteLine(Amazon);

      Console.WriteLine("__________________________________________________________________");
      Console.WriteLine();

      // Print the trees property to the console.
      Console.WriteLine(Amazon.trees);

      // Call the Grow() method.
      Amazon.Grow();  // trees += 30

      // Print the trees property again to the console to confirm that the Grow() method works.
      Console.WriteLine(Amazon.trees);

      Console.WriteLine("-------------------------------------");

      Forest f2 = new Forest("2026.01");
      Console.WriteLine(f2);

    }
  }
}
