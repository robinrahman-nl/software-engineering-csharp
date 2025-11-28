// See https://aka.ms/new-console-template for more information

/*
Space Mission Inventory
You are the inventory manager for a space mission. Your task is to catalog the list of items needed for the space mission, make sure the inventory is complete, update the items during the mission, and find specific items from the list. You’ll do all of this using C# arrays.

Let’s get started!

Tasks
0/10 complete
Mark the tasks as complete by checking them off
Initializing the Inventory
1.
Declare a string array called spaceInventory. This array will hold the list of items needed for the space mission.

2.
Initialize your spaceInventory array with the following items as strings:

Space Suits
Oxygen Tanks
Food Supplies
Medical Kits
Communication Devices
Fuel Canisters
Navigation Tools
Repair Tools
3.
Next, declare and initialize an array named itemQuantities that stores the quantities for each of the 8 items. Set the quantity of each item as appears in the table below:

Item	Quantity
Space Suits	10
Oxygen Tanks	8
Food Supplies	15
Medical Kits	5
Communication Devices	6
Fuel Canisters	9
Navigation Tools	4
Repair Tools	7
Validating and Updating the Inventory
4.
Check if the spaceInventory array contains 8 items. If so, print "Space Inventory is ready to go!" to the console.

If the spaceInventory array has more than 8 items, it should print "Too many items!". If it has less than 8 items, print "Add more items!".

5.
Next, let’s check what the second item in the spaceInventory array is.

Print the second item of the spaceInventory array along with its quantity from the itemQuantities array.

6.
You receive new instructions to replace the last item in the spaceInventory with "Scientific Instruments". Update the last item accordingly.

7.
Similarly, update the quantity of the replaced "Scientific Instruments" item in the itemQuantities array to 5.

Managing the Inventory
8.
Find the index of the first item that has a quantity of 5 in the itemQuantities array.

Then, print "The first item with quantity 5 is at position <INDEX>." where INDEX is the array index of the item.

9.
Next, reverse the order of the items in the spaceInventory.

Then, print the first and last items to confirm the reversal was successful.

10.
Finally, sort the spaceInventory array alphabetically. Then, print the first and last items again to confirm the sort operation was successful.
*/
// Declare an Array
string[] spaceInventory;

// Initialize an Array
spaceInventory = new[] { "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Cannisters", "Navigationa Tools", "Repair Tools" };
int[] itemQuantities = new int[] { 10, 8, 15, 5, 6, 9, 4, 7 };

if (spaceInventory.Length == 8)
{
  Console.WriteLine("Space Inventory is ready to go!");
}
else if (spaceInventory.Length > 8)
{
  Console.WriteLine("Too many items!");
}
else
{
  Console.WriteLine("Add more items!");
}

Console.WriteLine($"{spaceInventory[1]}, {itemQuantities[1]}");

// replace the last item in the spaceInventory with "Scientific Instruments".
spaceInventory[7] = "Scientific Instruments";
itemQuantities[7] = 5;

// 8.
// Find the index of the first item that has a quantity of 5 in the itemQuantities array.
int positionFirstItemQuantity_5 = Array.IndexOf(itemQuantities, 5);

// Then, print "The first item with quantity 5 is at position <INDEX>." where INDEX is the array index of the item.
Console.WriteLine($"The first item with quantity 5 is at position {positionFirstItemQuantity_5}");

// 9. Next, reverse the order of the items in the spaceInventory.
Array.Reverse(spaceInventory);

// print the first and last items to confirm the reversal was successful.
Console.WriteLine(spaceInventory[0]);

// 10. sort the spaceInventory array alphabetically.
Array.Sort(spaceInventory);

// 11.  print the first and last items again to confirm the sort operation was successful.
Console.WriteLine($"{spaceInventory[0]} {spaceInventory[7]}");