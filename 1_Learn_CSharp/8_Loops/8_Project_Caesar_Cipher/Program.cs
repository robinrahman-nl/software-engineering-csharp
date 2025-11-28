// See https://aka.ms/new-console-template for more information

/*
Caesar Cipher
Your team’s project for the company hackathon is nearly finished and is getting substantial attention from other teams. A few days before the competition is set to end, the leader of your team approaches you and says she is suspicious that another team has been intercepting emails about your group’s project!

As the team’s C# expert, you have been asked to write a cipher — a tool to encrypt text — in order to make your emails unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

To use the cipher, it may be helpful to draw the alphabet in a circle like so:

Alphabet with letters arranged in a circle. The letter 'A' is at the top, with the alphabet moving forward in a clockwise motion. The letter 'Z' meets 'A' back at the top

Take every letter of your message and shift it 3 places forward in the alphabet — in the circle diagram, 3 places to the right. For example, A becomes D, B becomes E, C becomes F, and “email” becomes “hpdlo”. In this case, 3 would be considered the “key” of the cipher.

A zoomed-in portion of the previous circle diagram of the alphabet, showing the letters 'A' through 'E'. There is a label indicating that the key is 3, and the letters 'A' and 'D' are highlighted. An arrow points from 'A' to 'D', indicating that with a key of 3, the cipher would convert 'A' to 'D'.

While shifting, if the cipher reaches the end of the alphabet, it will loop back around to the other side. For example, with the same key of 3, X becomes A, Y becomes B, and Z becomes C.

Your teammates can decrypt your messages by reversing this process — shift each letter 3 places backward in the alphabet, or to the left on the circle diagram.

For this project, you’ll need to convert strings to arrays of characters with ToCharArray():

string msgString = "brutus";
char[] msgArray = msgString.ToCharArray(); // {'b', 'r', 'u', 't', 'u', 's'}

Copy to Clipboard

You’ll also need to convert arrays of characters to strings with Join():

char[] msgArray = new char[] {'b', 'r', 'u', 't', 'u', 's'};
string msgString = String.Join("", msgArray); // "brutus"

Copy to Clipboard

The team is counting on you — let’s get started!

Tasks
0/14 complete
Mark the tasks as complete by checking them off
Prepare for Encryption
1.
You’ll build the encryption tool as an interactive console app. We’ve already provided an array of chars representing the letters of the alphabet, in order.

First, prompt the user for a secret message and store the result in a variable.

2.
Convert the captured string to an array of characters. Store the result in a new variable called secretMessage.

3.
Create a new, empty array of characters to hold the encrypted message. It should be named encryptedMessage and have the same length as secretMessage.

Encrypt
4.
We’ll need to perform encryption for every letter in the message.

Create an empty for loop that loops through each character of secretMessage.

The iterator variable should be called i and start at 0.
It should continue as long as i is less than secretMessage.Length.
After each iteration, i should be incremented by 1.
5.
Within the loop, access the character at position i in the secretMessage array and store it in a variable.

6.
Find the position of the current character in the alphabet array using the method Array.IndexOf(). Store the value in a variable.

7.
Add 3 to the letter position and store the value in a variable.

8.
Find the new encrypted character by getting the character in the alphabet array with that new position.

9.
Add the encrypted character to the array encryptedMessage.

Store the encrypted character at the index i (the iterator variable).

Test and Improve
10.
Your loop is finished! Now we need to convert our array of encrypted characters back into a readable string that we can print to the console.

Convert the character array to a string using String.Join() and print it to the console.

11.
Run your app and try these messages (not all of them may work yet!):

hello converts to khoor
citizen converts to flwlchq
12.
What went wrong? When the program tried to encrypt the z in citizen, it found its index in the alphabet, 25. It looked up the letter 3 spaces to the right, which would be alphabet[28].

This threw an error because the alphabet is only 26 letters!

We can “wrap around” by using the modulo operator — %. On the line where you add 3 to the letter position, surround the expression letterPosition + 3 with parentheses and take the modulo of 26, or alphabet.Length.

Now the new letter position will never go past 26.

13.
Test the code again with citizen, which converts to flwlchq.

Extensions
14.
Well done! You built an automated encryption engine that your team can use to communicate in secrecy. The hackathon is all but won!

If you’d like, you can keep building on your app:

The app doesn’t work with uppercase letters. Fix that by converting any message to lowercase.
The app doesn’t work with symbols, like ! or ?, or with whitespace characters. Skip any symbols and whitespace in your loop so that they are not encrypted.
*/

// string mssgString = string.Join("", secretMessage);

char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


// 1. prompt the user for a secret message and store the result in a variable.
Console.WriteLine("Type a secret message");

// 2. Convert the captured string to an array of characters. Store the result in a new variable called secretMessage.
char[] secretMessage = Console.ReadLine().ToCharArray(); // {r, o, b, i, n}

// 3. Create a new, empty array of characters to hold the encrypted message. It should be named encryptedMessage and have the same length as secretMessage.
char[] encryptedMessage = new char[secretMessage.Length]; // {}

// 4. We’ll need to perform encryption for every letter in the message. Create an empty for loop that loops through each character of secretMessage.
for (int i = 0; i < secretMessage.Length; i++)
{

  char j = secretMessage[i];


  int positionInAlphabetArray = Array.IndexOf(alphabet, j);
  Console.WriteLine(positionInAlphabetArray); // 17
  int newPositionInAlphabetArray = (positionInAlphabetArray += 3) % alphabet.Length; // 20
  Console.WriteLine(newPositionInAlphabetArray); // 20 

  // Find the new encrypted character by getting the character in the alphabet array with that new position. Add the encrypted character to the array encryptedMessage. Store the encrypted character at the index i (the iterator variable).
  encryptedMessage[i] = alphabet[newPositionInAlphabetArray];
}


Console.WriteLine(string.Join(",",encryptedMessage)); // urelq
