using System;

namespace Review
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;
    // Constructor 1
    public Forest(string name, string biome)
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }
    // Constructor 2. With 
    // : this () -> for reuse code from  constructor 1. 
    public Forest(string name) : this(name, "Unknown")
    {
      Console.WriteLine("No biome provided, using default value \"Unknown\".");
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
      return $"name: {name}\ntrees: {trees}\nage: {age}\nbiome: {biome}";
    }

  


  }

}