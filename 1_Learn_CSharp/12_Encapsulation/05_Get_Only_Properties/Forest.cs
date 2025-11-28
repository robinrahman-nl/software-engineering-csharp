using System;

namespace GetOnlyProperties
{
  class Forest
  {
    // 1. In Forest.cs, define an Age property for the age field. It should have a public getter and a private setter.
    private int age;
    public int Age
        {
            get {return age;}
            private set { age = value;}
        }
    
    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    private string biome;
    public string Biome 
    {
      get {
        return biome;
      }
      set {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) {
          biome = value;
        }
        else {
          biome = "Unknown";
        }
      }
    }
  }

}