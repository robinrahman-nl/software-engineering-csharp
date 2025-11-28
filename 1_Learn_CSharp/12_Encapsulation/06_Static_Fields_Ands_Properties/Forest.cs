using System;
using System.Dynamic;

namespace StaticFields
{
  public class Forest
  {


    // FIELDS/PROPERTIES

    // 1. Let’s create a static property on the Forest class to keep track of the total number of forests created. 
    //    Define a public static property named ForestsCreated with a public getter and a private setter.
    public static int ForestsCreated
    { get; private set; }


    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    private int age;   // Field
    public int Age     // Property with conditional setter. 
    {
      get { return age; }
      private set
      {
        if (value < 0)
        {
          age = 0;
        }
        else
        {
          age = value;
        }
      }
    }

    private string biome;   // Field
    public string Biome     // Property with conditional setter. 
    {
      get { return biome; }
      set
      {
        string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
        if (Array.IndexOf(validBiomes, value) >= 0) // Array.IndexOf(validBiomes, value) => returns -1 if false. 
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    


    // CONSTRUCTORS
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
      ForestsCreated++;  // 2. In the first constructor, increment ForestsCreated. This will add 1 to the property every time a Forest object is constructed.
    }

    public Forest(string name) : this(name, "Unknown")  // C# does not run the second constructor directly —  The second constructor says, “Run the first constructor, but pass in these arguments (name, "Unknown")”.
    { }


    // METHODS
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    // ########################################################################
    // 🖨️ Override ToString() to customize console output
    public override string ToString()
    {
      return $"name: {Name}\nbiome: {biome}\ntrees: {Trees}\nage: {age}\nForestCreated: {ForestsCreated}";
    }
  }
}
