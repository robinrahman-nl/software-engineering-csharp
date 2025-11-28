// See https://aka.ms/new-console-template for more information


/*
Office Inventory Management System
Suppose you are an office manager responsible for maintaining the inventory of office supplies and equipment. Your task is to build a program that manages this inventory efficiently. Throughout this project, you will use C# lists to store and manipulate the inventory data.

Let’s get started!

Tasks
0/11 complete
Mark the tasks as complete by checking them off
Setting Up the Initial Inventory
1.
We’ll be working with lists to manage the office inventory.

Import System.Collections.Generic at the top of the InventoryManagement.cs file.

2.
Inside the Main() method, create an empty list called inventoryList of type string to store the office inventory items.

3.
Add the initial set of inventory items to inventoryList. Include the following items:

“Printer”
“Laptop”
“Desk Chair”
“Monitor”
“Keyboard”
Updating the Inventory
4.
Let’s see how many items we have in our office inventory.

Print the total number of items in the inventoryList to the console.

5.
Next, check if "Desk Chair" exists in the inventoryList and store the result in a bool variable called hasDeskChair. Print the value of hasDeskChair to the console.

6.
Remove the "Printer" from the inventoryList and store the result in a bool variable called removed. Print the value of removed to the console.

7.
Let’s take a look at our updated inventory after removing "Printer".

Print each element of the updated inventoryList to the console.

Updating Multiple Elements in the Inventory
8.
We just received some new office supplies!

Create a new list of type string named newItems initialized with items "Mouse" and "Desk Lamp".

9.
Now, add all items in newItems to inventoryList.

10.
The two items we just received were mistakenly delivered and need to be returned.

Remove the last two items from inventoryList.

11.
Lastly, store the first three items in inventoryList in a new list called topInventory.

Print each item in topInventory to the console.
*/

using System;

// 1. We’ll be working with lists to manage the office inventory. Import System.Collections.Generic at the top of the InventoryManagement.cs file.
using System.Collections.Generic;
public class InventoryManagement
{
  public static void Main(string[] args)
  {
    // Your code goes here
    // 2. Inside the Main() method, create an empty list called inventoryList of type string to store the office inventory items.
    List<string> inventoryList = new List<string>();

    // 3. Add the initial set of inventory items to inventoryList. Include the following items: “Printer” “Laptop” “Desk Chair” “Monitor” “Keyboard”
    inventoryList.AddRange(new List<string> { "Printer", "Laptop", "Desk Chair", "Monitor", "Keyboard" });

    // 4. Print the total number of items in the inventoryList to the console.
    Console.WriteLine(inventoryList.Count);

    // 5. check if "Desk Chair" exists in the inventoryList.
    bool hasDeskChair = inventoryList.Contains("Desk Chair");
    Console.WriteLine(hasDeskChair); // Printe True

    // 6. Remove the "Printer" from the inventoryList and store the result in a bool variable called removed. Print the value of removed to the console.
    bool removed = inventoryList.Remove("Printer");
    Console.WriteLine(removed); // Prints True

    // 7. Let’s take a look at our updated inventory after removing "Printer". Print each element of the updated inventoryList to the console.
    foreach (string item in inventoryList)
    {
      Console.WriteLine(item);
    }
    // 8. Create a new list of type string named newItems initialized with items "Mouse" and "Desk Lamp".
    List<string> newItems = new List<string> { "Mouse", "Desk Lamp" };

    // 9. Now, add all items in newItems to inventoryList.
    inventoryList.AddRange(newItems);
    foreach (string item in inventoryList) { Console.WriteLine(item); } // Laptop // Desk Chair // Monitor // Keyboard // Mouse // Desk Lamp

    // 10. The two items we just received were mistakenly delivered and need to be returned. Remove the last two items from inventoryList.
    inventoryList.RemoveRange(4, 2);

    // 11. Lastly, store the first three items in inventoryList in a new list called topInventory. Print each item in topInventory to the console.
    List<string> topInventory = inventoryList.GetRange(0, 3);
    foreach (string item in topInventory) { Console.WriteLine(item); } // Laptop // Desk Chair // Monitor 
  }
}
