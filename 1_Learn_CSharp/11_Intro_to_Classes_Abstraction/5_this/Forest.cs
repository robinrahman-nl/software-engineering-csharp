using System;

namespace ThisKeyword
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    // For each instance variable that is used within the method body, add the this keyword to specify that it refers to the instance variable.
    // NOTE: adding this here does not change how the code works.
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
  }

}

