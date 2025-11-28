using System;

namespace StarLifecycleSimulator
{
  public class Star
  {
    public string name;
    public string type;
    public int age;
    public double luminosity;

    // 3. Define a constructor that takes two parameters: a string for the star’s name and another string or its type.
    //    inside the constructor, assign the two parameter values to the corresponding instance fields. Additionally, initialize age to 0 and brightness to 1.0.
    public Star(string name, string type)
    {
      this.name = name;
      this.type = type;
      age = 0;
      luminosity = 1.0;
    }

    // 4. Define a second constructor that only takes one parameter, string name, and sets the type to "Unknown".
    //    The constructor should also print "Star type set to default: Unknown." to the console.

    public Star(string name) : this(name, "Unknown")
    {
      Console.WriteLine("Star type set to default: Unknown.");
    }

    // 5. Create a method called Shine
    //    that prints the following to the console: "Star <NAME> is shining with brightness <BRIGHTNESS>." where NAME and BRIGHTNESS are the instance’s name and brightness values.
    public void Shine()
    {
      Console.WriteLine($"Star {name} is shining with brightness {luminosity}");
    }


    // 6. Create a GrowOlder method that increases the age by 1 billion years and decreases the brightness by 10%.
    public void GrowOlder()
        {
            age ++ ;
            luminosity *= 0.9;
        }

    // 7. Create a Supernova method that sets brightness to 0 and prints "Star <NAME> has exploded in a supernova."
    public void Supernova()
        {
            luminosity = 0;
            Console.WriteLine($"Star {name} has exploded in a supernova.");
        }















    // 🖨️ Override ToString() to customize console output
    public override string ToString()
    {
      return $"name: {name}\ntype: {type}\nage: {age}\nluminousity: {luminosity}";
    }




  }
}