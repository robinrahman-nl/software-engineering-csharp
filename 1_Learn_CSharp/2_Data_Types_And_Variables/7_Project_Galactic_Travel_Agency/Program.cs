/*
Galactic Travel Agency
You are tasked with managing passenger profiles for a Galactic Travel Agency. Each passenger has a name, age, ticket type, and preferred planet to visit. Using C#, you’ll start by creating these variables, manipulating them for different operations, and applying data conversions where needed.

Let’s get started!

Tasks
0/12 complete
Mark the tasks as complete by checking them off
Creating Passenger Profiles
1.
Let’s start by creating some variables to store passenger data.

Create a string variable called passengerName and assign it to "Zara".

2.
Next, create an integer variable called passengerAge and assign it to 28.

3.
Create a string variable called ticketType and assign it the "First Class" ticket type.

4.
Lastly, create a string variable called preferredPlanet and assign it to "Mars".

Printing and Basic Operations
5.
Let’s take a look at the stored passenger data.

Print the passengerName to the console.

6.
Next, print the passengerAge to the console.

7.
Print the ticketType to the console.

8.
Finally, print the preferredPlanet to the console.

9.
We’ve made a mistake with the passenger’s age!

Increment the passengerAge by 1 and print the new age to the console.

Explicit and Implicit Conversions
10.
Explicitly convert the passengerAge to a double and assign it to a variable called passengerAgeDouble.

Print passengerAgeDouble to the console.

11.
Implicitly convert passengerAge to a double and assign it to passengerAgeDouble2.

Print passengerAgeDouble2 to the console.

12.
Finally, convert the passengerAge to a string using Convert.ToString() and assign it to a variable called passengerAgeString.

Print passengerAgeString to the console.
*/

using System;

public class GalacticTravelAgency
{
  public static void Main(string[] args)
  {
    // Your code goes here
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);


    passengerAge = passengerAge + 1;
    Console.WriteLine(passengerAge);

    // 10.
    // Explicitly convert the passengerAge to a double and assign it to a variable called passengerAgeDouble.
    // Print passengerAgeDouble to the console.
    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine(passengerAgeDouble);

    // 11.
    // Implicitly convert passengerAge to a double and assign it to passengerAgeDouble2.
    // Print passengerAgeDouble2 to the console.
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);

    //
    // Finally, convert the passengerAge to a string using Convert.ToString() and assign it to a variable called passengerAgeString.
    // Print passengerAgeString to the console.
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);











  }
}
