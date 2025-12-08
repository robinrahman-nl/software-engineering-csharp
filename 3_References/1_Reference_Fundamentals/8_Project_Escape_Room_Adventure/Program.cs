/*
Escape Room Adventure
You are a secret agent tasked with infiltrating a high-security laboratory where a group of hackers is planning a major cyber attack. Your goal is to disable their equipment by manipulating system files and data structures. To achieve that, you must solve puzzles involving references and value types in C#.

Let’s get started.


*/

/*

Setting Up Camp
1.
Create a new file called FieldAgent.cs.

In FieldAgent.cs, create a class called FieldAgent with two properties:

Name of type string
SecretCode of type int
2.
Navigate to Program.cs.

Instantiate a FieldAgent object named agent1. Then, set its Name to "Agent Smith" and SecretCode to 007.

3.
Create another reference of type FieldAgent named agent2 that refers to the same FieldAgent object as agent1.

4.
Change the SecretCode of agent2 to 999 and print out the SecretCode for both agent1 and agent2.

File Encryption
5.
Create a file called File.cs.

Inside, create a class called File with two properties:

FileName of type string
FileSize of type int
6.
Navigate to Program.cs.

Instantiate a File object named file1. Then, set its FileName to "Confidential.txt" and the FileSize to 1024.

7.
Create another File object named file2. Set its FileName also to "Confidential.txt" and the FileSize to 1024.

8.
Create a boolean variable called sameFile and store the result comparing whether file1 is equal to file2.

9.
Print the value of sameFile to the console.

Navigating through Servers
10.
Create a file called ISystem.cs.

Inside, create an interface called ISystem with a method named Operate() that returns nothing and a string property named Status.

11.
Next, create another file called Server.cs.

Inside, define a class Server that implements ISystem. Create a property called Status of type string and implement the Operate() method to print "Server is <STATUS>" where STATUS is the value of the Server‘s Status.

12.
Navigate to Program.cs.

Create instances of the Server class named mainServer and backupServer.

Set the mainServer‘s Status property to "Active" and the backupServer‘s Status property to "Inactive".

13.
Lastly, create an array of ISystem named systems containing mainServer and backupServer.

Loop through the array to call the Operate() method on each element.
*/

using System;

namespace EscapeRoomAdventure
{
    

public class Program {
  public static void Main(string[] args) {
    // Your code goes here

    FieldAgent agent1 = new FieldAgent();

    agent1.Name = "Agent Smith";
    agent1.SecretCode = 007;

    Console.WriteLine(agent1.Name);
    Console.WriteLine(agent1.SecretCode);

    // 3. Create another reference of type FieldAgent named agent2 that refers to the same FieldAgent object as agent1.
    FieldAgent agent2 = agent1;

    // 4. Change the SecretCode of agent2 to 999 and print out the SecretCode for both agent1 and agent2.
    agent2.SecretCode = 008;
    Console.WriteLine( agent1.SecretCode); // 008
    Console.WriteLine(agent2.SecretCode); // 008

    // Instantiate a File object named file1. Then, set its FileName to "Confidential.txt" and the FileSize to 1024.
    File file1 = new File();
    file1.FileName = "Confidential.text";
    file1.FileSize = 1024;

    // 7. Create another File object named file2. Set its FileName also to "Confidential.txt" and the FileSize to 1024.        
    File file2 = new File();
    file2.FileName = "Confidential.text";
    file2.FileSize = 1024;
    
    // 8. Create another File object named file2. Set its FileName also to "Confidential.txt" and the FileSize to 1024.
    bool sameFile = (file1 == file2);
    Console.WriteLine(sameFile);
    
    // 12. Create instances of the Server class named mainServer and backupServer. 
    // Set the mainServer‘s Status property to "Active" 
    // and the backupServer‘s Status property to "Inactive".
    Server mainServer = new Server();
    Server backupServer = new Server();

    mainServer.Status = "Active";
    backupServer.Status = "Inactive";

    // 13. create an array of ISystem named systems containing mainServer and backupServer. 
    // Loop through the array to call the Operate() method on each element.

    ISystem[] systems = new ISystem[] {mainServer, backupServer};

    foreach (ISystem system in systems)
    {
        system.Operate();
    }

  }
}
}