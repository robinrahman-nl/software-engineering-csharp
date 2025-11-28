using System;

namespace Properties
{
  public class Forest
  {
    private string name;

    public int trees;
    public int age;
    private string biome;
    /* 
    #############################################################
     Getter and Setters
    #############################################################
    */
    
    // 1. define a basic Name property for the name field. 
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // 2. define a Biome property for the biome field, with a getter and setter. The setter should only allow three values: "Tropical", "Temperate", and "Boreal". If any other value is used, set biome to "Unknown".
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal")
        {
          biome = value;
        }
        else { biome = "Unknown"; }
      }
    }
  }
}
