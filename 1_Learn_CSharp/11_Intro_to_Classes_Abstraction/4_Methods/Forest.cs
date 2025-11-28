using System;

namespace Methods
{
  public class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    // 1. In the Forest class, define a public method Grow(). 
    // It should: 
    //  . take zero arguments 
    //  . increase the trees property by 30 and the age property by 1 
    //  . return the updated number of trees

    public int Grow()
    {
      trees += 30;
      age++;
      return trees;
    }

    // 2. Define a public method Burn(). 
    // It should:  
    // . take zero arguments 
    // . decrease the trees field by 20 and 
    // . increase the age property by 1 
    // . return the updated number of trees

    public int Burn()
    {
      trees -= 20;
      age++;
      return trees;
    }

  }

}

