using System;

namespace Constructors
{
  public class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

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
    
    public Forest(string name, string biome)
        {
      this.name = name;
      this.biome = biome;
      this.age = 1;
        }

  }

}

