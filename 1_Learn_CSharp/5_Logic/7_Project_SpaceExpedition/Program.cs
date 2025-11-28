// See https://aka.ms/new-console-template for more information

/*
Space Expedition Boolean Adventure
You’re the captain of a space expedition aimed at discovering new planets. Your space agency has established a set of parameters that need regular evaluations to make informed decisions. These parameters include atmospheric quality, gravity levels, and resource availability. Your task is to use boolean logic and comparison operators in C# to make sure each planet is suitable for exploration.

Tasks
0/11 complete
Mark the tasks as complete by checking them off
Establishing Boolean Parameters
1.
Create a boolean variable named isAtmosphereBreathable and set it to true.

2.
Next, create another boolean variable named isGravityStable and set it to false.

3.
Lastly, create a boolean variable named resourcesSufficient and set it to true.

Evaluating Planet Conditions
4.
Evaluate the value of isAtmosphereBreathable and isGravityStable. Save the result to a new variable called isHabitable.

5.
Print the value of isHabitable to the console to check if the planet is habitable.

6.
Next, evaluate the value of isGravityStable or resourcesSufficient. Save the result to a new variable called suitableForExpansion.

7.
Print the value of suitableForExpansion to the console.

Making Decisions
8.
Create an integer variable named currentCrew and set it equal to 5 since you have 5 crew members on board.

9.
Next, create an integer variable named maxCrewCapacity and set it equal to 10, representing the maximum crew the ship can carry.

10.
Use a comparison operator to check if currentCrew is less than maxCrewCapacity, and store the result in a variable called canAcceptMoreCrew.

11.
Lastly, print the value of canAcceptMoreCrew to the console to see if you can accept more crew members.
*/

bool isAtmosphereBreathable = true;
bool isGravityStable = false;
bool resourcesSufficient = true;

bool isHabitable = isAtmosphereBreathable && isGravityStable;
Console.WriteLine(isHabitable); // false

bool suitableForExpansion = isGravityStable && resourcesSufficient;
Console.WriteLine(suitableForExpansion); // false

int currentCrew = 5;
int maxCrewCapacity = 10;

bool canAcceptMoreCrew = currentCrew < maxCrewCapacity; 
Console.WriteLine(canAcceptMoreCrew);