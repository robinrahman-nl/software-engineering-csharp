/*
Create a Superclass
A superclass is defined just like any other class:

class Vehicle
{
}

Copy to Clipboard

And a subclass inherits, or “extends”, a superclass using the colon syntax:

class Sedan : Vehicle
{
}

Copy to Clipboard

The above code means that Sedan will inherit all the functionality of the Vehicle class.
*/

/*
1.
In Vehicle.cs, build an empty Vehicle class within the LearnInheritance namespace.

Checkpoint 2 Passed
2.
In Vehicle.cs, define:

string LicensePlate property (getter only)
double Speed property (getter and private setter)
int Wheels property (getter only)
void Honk() method
SpeedUp() method
SlowDown() method
SpeedUp() and SlowDown() should add and remove 5 from Speed, respectively.

Honk() should write a message to the console (such as HONK!).

Checkpoint 3 Passed
3.
In Sedan.cs, use the colon syntax to declare that Sedan inherits the Vehicle class.

Checkpoint 4 Passed
4.
Do you see a bunch of warning CS0108 in the console? Since Sedan is inheriting members from Vehicle, those members should not be redefined!

Remove all of the inherited members from Sedan.cs. You will still see errors regarding Sedan accessing members that it is not allowed to — that’s okay! We’ll fix those in the next exercise.
*/