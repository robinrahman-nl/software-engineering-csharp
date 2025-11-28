/*
The Object of Your Affection
Your friend is building a new match-making service: The Object of Your Affection or OOYA for short (don’t worry, you still have time to convince them to change the name).


With your new understanding of C# objects and classes, your friend thought you could build a pretty well-organized system of dating profiles.

Your first step? Build a Profile class that allows users to generate profile objects.

The Profile should store the following information about a single user:

name
age
city
country
pronouns
hobbies
And this is how users should be able to interact with their own profiles:

create a new profile with some information
add hobbies
view profile
*/

using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakulla", 22, "Amsterdam", "NL", "He/ Him");
      // Console.WriteLine(sam.name);

      sam.SetHobbies(new string[] {"cricket", "running"});
      Console.WriteLine(sam.ViewProfile());



      // Console.WriteLine($"########################################################################\n{sam}\n########################################################################");

    }
  }
}
