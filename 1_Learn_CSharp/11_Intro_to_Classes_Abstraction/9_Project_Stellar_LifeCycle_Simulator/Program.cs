/*
Stellar Lifecycle Simulator
You are a star scientist studying various stars in the universe. To simulate and monitor the lifecycles of stars efficiently, create a program that models the properties and behaviors of stars using a class in C#.

Tasks
0/8 complete
Mark the tasks as complete by checking them off
Defining the Star Class
1.
Open the file navigator and create a new file named Star.cs. Define a public Star class.

2.
Within the Star class, define the following public fields:

name of type string
type of type string
age (in billion years) of type int
brightness (in luminosity units) of type double
Setting Up the Constructors
3.
Define a constructor that takes two parameters: a string for the star’s name and another string or its type.

Inside the constructor, assign the two parameter values to the corresponding instance fields. Additionally, initialize age to 0 and brightness to 1.0.

4.
Define a second constructor that only takes one parameter, string name, and sets the type to "Unknown".

The constructor should also print "Star type set to default: Unknown." to the console.

Adding Behaviors
5.
Create a method called Shine that prints the following to the console:

"Star <NAME> is shining with brightness <BRIGHTNESS>."

Copy to Clipboard

where NAME and BRIGHTNESS are the instance’s name and brightness values.

6.
Next, create a GrowOlder method that increases the age by 1 billion years and decreases the brightness by 10%.

Read the hint for details on how to perform these calculations correctly.

7.
Lastly, create a Supernova method that sets brightness to 0 and prints

"Star <NAME> has exploded in a supernova."

Copy to Clipboard

where NAME is the object’s name value.

8.
Navigate to Program.cs and uncomment the code following * Star Simulations * in Main().

Run the code to see the Stellar Lifecycle Simulator in action!
*/



using System;

namespace StarLifecycleSimulator
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Star Simulations */

      Star sun = new Star("Sun", "G-Type");
      sun.Shine();
      sun.GrowOlder();
      sun.Shine();
      sun.Supernova();

      Star unknownStar = new Star("Mystery Star");
      unknownStar.Shine();
      unknownStar.GrowOlder();

      
    }
  }
}














