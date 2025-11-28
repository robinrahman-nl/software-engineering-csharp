using System;

namespace AutoImplementedProperties
{
  class Forest
  {
    /*private string name;
    public string Name
    {
      get {
        return name;
      }
      set {
        name = value;
      }
    } */


    // 1. Replace the current name field and Name property with an auto-implemented Name property.
    public string Name
        {get; set;}

    
    /* private int trees;
    public int Trees
    {
      get {
        return trees;
      }
      set {
        trees = value;
      }
    } */

    // 2. Replace the current trees field and Trees property with an automatic Trees property.
    public int Trees
    {get; set;}

    public int age;

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