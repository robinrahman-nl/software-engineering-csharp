/*
Fields
Our 
classes
Preview: Docs Loading link description
 often need to associate different pieces of data, such as a size or name, with each instance. In C#, these pieces of data are called fields. Fields are a type of class member, a general term for the components of a class.

We can create fields like this:

class Item {
  public string description;
  public int count;
}

Copy to Clipboard

Each field is similar to a variable and can have different values for each instance.

In the code above, we haven’t set the value of either field, so they have default values. For instance, string defaults to null, and int defaults to 0. You can find the default values for more types in Microsoft’s default values table.

It’s common practice to name fields using all lowercase characters (e.g., description instead of Description), making them easier to recognize.

Ignore the public keyword for now — it will be explained in the next lesson. In this lesson, we will point out any places where public is needed for the code to work.

Once we create an Item instance, we can access and modify each field using dot notation:

Item bag = new Item();
bag.description = "Paper bag with handles";
bag.count = 4;
Console.WriteLine(bag.description); // Prints "Paper bag with handles"

Item bottle = new Item();
bottle.description = "Plastic water bottle with sealed lid";
bottle.count = 5;
Console.WriteLine(bottle.count); // Prints "5"

Copy to Clipboard

Each instance has a description and count field, but their values may differ across instances.
*/



