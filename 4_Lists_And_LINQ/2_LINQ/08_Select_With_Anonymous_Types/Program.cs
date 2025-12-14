/*
elect With Anonymous Types
Sometimes, when working with LINQ queries, we may be selecting from a collection of complex types. If we want to select a single property from these instances, we can just select the value: select instance.Field. But what happens when we want a result with two or three values?

If we’re selecting instances of a type with dozens of fields and properties, it seems a waste of memory and resources to select multiple instances of this type just for the sake of a couple of values.

Fortunately, C# provides a solution to this problem called anonymous types.

Anonymous types are types without a class declaration. They only consist of public read-only fields, and are created using the new keyword with an object initializer. The compiler does not have access to the name of the type so these types must be stored in a var variable. Creating one of these types outside of a LINQ query looks like this:

var anonymousValue = new { StringValue = "Hello World", NumericValue = 100 };

Copy to Clipboard

In the above example, anonymousValue.StringValue and anonymousValue.NumericValue which would return a string or an int respectively. The declaration of the anonymous type doesn’t use type declarations, the data type for each field is inferred from the value passed to it. We access these fields the same way as fields in any other type.

Using this in a LINQ query would look something like this:

var anonymousValue = from a in ComplexTypeCollection
  where a.SomeValue == true
  select new { value1 = a.StringValue, value2 = a.NumericValue, value3 = a.BooleanValue };

Copy to Clipboard

This would return an IEnumerable<T> of anonymous types that only have three fields: value1, value2 and value3.

There is a shorter version of this syntax that infers the field names from the field/property names of the type that we’re returning. That looks like this:

var anonymousValue = from a in ComplexTypeCollection
  where a.SomeValue == true
  select new { a.StringValue, a.NumericValue, a.BooleanValue };

Copy to Clipboard

In this case, the anonymous type will have field names of StringValue, NumericValue and BooleanValue.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Hero
  {
    public string Name;
    public string Class;
    public string Race;
    public int Strength;
    public int Wisdom;
    public int Dexterity;

    public Hero (string n, string c, string r, int s, int w, int d)
    {
      this.Name = n;
      this.Class = c;
      this.Race = r;
      this.Strength = s;
      this.Wisdom = w;
      this.Dexterity = d;
    }
  }

  class Program
  {
    static void Main()
    {
      Hero[] heroes = { 
        new Hero("Zoe","Fighter","Dwarf",18,8,11), 
        new Hero("Liam","Wizard","Elf",8,18,11), 
        new Hero("Taryn","Thief","Hafling",11,8,18), 
        new Hero("Dorian","Cleric","Human",8,18,11)};


// Initializing LINQ query.
    var strongHeroes = from h in heroes
      where h.Strength > 10                         // Filter
      select new { h.Name, h.Class };               // Selects an anonymous type that only contains the hero classes name field and class field. // Ensure the fields are named Name and Class in the anonymous type.



    foreach (var h in strongHeroes)                 
    {
      Console.WriteLine($"{h.Name} {h.Class}");     // prints the hero’s Name and Class to the console.
    }
      
    }
  }
}