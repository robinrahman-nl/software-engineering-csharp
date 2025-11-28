using System;
using System.Reflection.Metadata.Ecma335;

namespace DatingProfile
{
  // 1. 
  // Tab over to Profile.cs and set up the skeleton of the Profile class.
  class Profile
  {
    //  2.
    // Add the following fields to Profile: // a string name // an int age // a string city // a string country // a string pronouns // a string[] hobbies 

    // We could implement these as properties, but we’ll use fields. 

    // Properties are used to: 
    // validate values
    // control external access

    // Later in this project, you’ll see how we achieve the same result with methods.
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // Constructor()

    // 5. 
    // Users should be able to add their profile information in a constructor. 
    // Below the fields, declare a constructor for Profile that allows you to set: // name // age // city // country // pronouns (give this a default value of "they/them" just in case it’s ever left blank)
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      hobbies = new string[] { };
    }

    // 7. 
    // We’d like users to see all of the information in a single, formatted string. Time to add a ViewProfile() method.
    //  define a ViewProfile() method under the constructor. 
    // It should have: // public access // a return type of string // no parameters
    // It should return a string containing all of the profile’s information.
    public string ViewProfile()
        {
          string clientHobbies = "Hobbies: ";
            if (hobbies.Length > 0)
            {
          foreach (string hobby in hobbies)
            {
                clientHobbies = $"{clientHobbies}" + " " +  hobby;
            }
            
            } 
            
            return $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\n{clientHobbies}";

        }

    // 8. You still need to give users a way to set hobbies.
    //    declare a new method SetHobbies() with: // public access // no return value // a string[] parameter named hobbies
    //    In the method body, set the field this.hobbies equal to the hobbies argument.
    public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }







    // 🖨️ Override ToString() to customize console output
    public override string ToString()
    {
      return $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: {hobbies}";
    }
  }
}
