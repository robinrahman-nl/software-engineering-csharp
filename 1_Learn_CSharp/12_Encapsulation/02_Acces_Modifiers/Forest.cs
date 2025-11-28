namespace AccessModifiers
{
  class Forest
  {
    public string name;

    // age and trees will not be accessible outside the class definition.
    private int trees;
    private int age;
    public string biome;

    public Forest(string name, string biome) 
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }

    public void Grow() 
    {
      trees += 20;
      age ++;
    }

    public void AnnounceForest()
    {
      Console.WriteLine($"The {name} {biome} Forest is {age} years old and has {trees} trees");
    }

  }

}

