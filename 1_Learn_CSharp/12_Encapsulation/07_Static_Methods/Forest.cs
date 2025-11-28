using System;

namespace StaticMethods
{
  public class Forest
  {
    // FIELDS/PROPERTIES

    // 1. 
    // Let’s create a method that outputs some information about forests in general. 
    // We’ll use a field and property to store the explanation. 
    // Start by defining a private static string field named forestFacts. Do not initialize forestFacts with a value.
    private static string forestFacts = "Test";  // field
    

    // 2. 
    // Next, define a private static property named ForestFacts with just a getter (no setter). 
    // Do not initialize ForestFacts with a value either.
    private static string ForestFacts // Property
    { 
      get {return forestFacts;} 
    }

    // 3. 
    // Finally, define a public static method named PrintForestFacts() that writes the value of ForestFacts to the console. 
    // Note that ForestFacts is never assigned a value — we’ll address this in the next exercise.

    public static void PrintForestFacts ()
        {
            Console.WriteLine(forestFacts);
        }


    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    private int age;
    public int Age
    { 
      get { return age; }
      private set {
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

    private string biome;
    public string Biome
    {
      get { return biome; }
      set
      {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) 
        {
          biome = value;
        }
        else 
        {
          biome = "Unknown";
        }
      }
    }
    
    public static int ForestsCreated
    {
      get; private set;
    }

    // CONSTRUCTORS
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
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
      return $"name: {Name}\nbiome: {biome}\ntrees: {Trees}\nage: {age}\nForestCreated: {ForestsCreated}\nforestFacts: {forestFacts}";
    }
    
  }
}
