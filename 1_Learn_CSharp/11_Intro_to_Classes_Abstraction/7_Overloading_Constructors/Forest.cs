using System;

namespace OverloadingConstructors
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    // First Constructor
    public Forest(string name, string biome) 
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }

    // Second Constructor
    // 1. Define a second constructor for the Forest class:
    // It should take 1 parameter, name.
    // It should use : this() with the name variable as the first argument and "Unknown" as the second.
    // It should also print a message to the console regarding the use of the default value.
    public Forest(string name) : this(name, "Unknown")
        {
            Console.WriteLine("Biome not specified, value defaulted to 'Unknown'");
        }

    public int Grow()
    {
      this.trees += 30;
      this.age++;
      return this.trees;
    }

    public int Burn() 
    {
      trees -= 20;
      age++;
      return trees;
    }



    // ✅ Override ToString() to customize console output
    public override string ToString()
    {
      return $"Forest name : {name}\nBiome: {biome}\nTrees: {trees}\nAge:{age}";
    }


  }

}