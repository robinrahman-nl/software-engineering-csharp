// See https://aka.ms/new-console-template for more information

/*
True or False?
You’re taking an interactive quiz written in C#. Everything is going fine until you respond to this question:

A terminal application states, 
"Eggplants are a type of berry."  "True or false?" 
 "yes" 
 "You got 0 out of 5 correct." 

This application wasn’t checking your input. When you used an unexpected format, it couldn’t ask the question again and marked your answer as wrong. (By botanical definition, eggplants really are berries).

In this project, you’ll build a C# program that presents a quiz the right way — using arrays and loops, it will check the user’s input and repeat the question if the input is invalid. After the quiz is complete, it will verify the user’s responses against the correct answers and present a score.
*/




string[] questions = {
  "An array in C# can only store elements of the same data type.",
  "You can change the size of an array in C# after it’s created.",
  "The first element in a C# array has an index of 1.",
  "The Length property of an array tells you how many elements it contains.",
  "You can declare and initialize an array in one line in C#."
};

bool[] answers = {
  true,
  false,
  false,
  true,
  true
};

// 3. Declare responses array of type bool[]. It should be an empty array with the same length as the questions array.
bool[] responses = new bool[questions.Length];

// 4.. To avoid any errors later on, write an if statement that checks if the length of the questions array IS NOT equal to the length of the answers array.
// If they are not equal, print a warning to the console.
if (questions.Length != answers.Length)
{
  Console.WriteLine("WARNING: Amount of questions should be equal to amount of answers");
}

int askingIndex = 0;

foreach (string question in questions)
{
  string input;
  bool isBool;
  bool inputBool;

  Console.WriteLine(question);
  Console.WriteLine("True or False?");
  input = (Console.ReadLine()).ToLower();

  if (input == "true" || input == "false")
  {
    isBool = true;
  }
  else
  {
    isBool = false;
  }


  // 11. We may have to re-prompt the user for input if they respond with an invalid value. Create an empty while loop within the foreach loop.
  // It should continue looping as long as isBool is false.

  while (!isBool)
  {
    Console.WriteLine("Please respond with 'true' or 'false'");
    input = (Console.ReadLine()).ToLower();
    if (input == "true" || input == "false")
    {
      isBool = true;
    }
    else
    {
      isBool = false;
      continue;
    }
  }

  // set inputBool to true if input is "true". Otherwise, input must be "false", so set inputBool to false.
  if (input == "true")
  {
    inputBool = true;
  }
  else
  {
    inputBool = false;
  }

  responses[askingIndex] = inputBool;
  askingIndex++;

}

Console.WriteLine(string.Join(", ", responses));


// 16.  compare those responses to the answers array and count the number of correct responses.
int scoringIndex = 0;
int count = 0;

// Create an empty foreach loop that iterates through each answer in answers.

foreach (bool answer in answers)
{
  bool checkResponse = responses[scoringIndex];
  Console.WriteLine($"Input: {checkResponse} | Anser: {answer}");

  // Now we’ll add to the user’s score if the response matches the answer.
  if (checkResponse == answer)
  {
    count++;
  }
  scoringIndex++;
}

Console.WriteLine($"You got {count} out of 5 correct!");
































// for (int askingIndex = 0; askingIndex < questions.Length; askingIndex++)
// {
//   Console.WriteLine(questions[askingIndex]);
//   string userAnswer = Console.ReadLine();

//   if (userAnswer != "true" && userAnswer != "false")
//   {
//     Console.WriteLine("Type true or false");
//     break;
//   }


//   bool userAnswerBoolean = Convert.ToBoolean(userAnswer);

//   responses[askingIndex] = userAnswerBoolean;

// }



// Console.WriteLine(string.Join(",", responses));


// string[] questions = {
//   "An array in C# can only store elements of the same data type.",
//   "You can change the size of an array in C# after it’s created.",
//   "The first element in a C# array has an index of 1.",
//   "The Length property of an array tells you how many elements it contains.",
//   "You can declare and initialize an array in one line in C#.",
//   "The last element in an array has an index equal to the array’s length.",
//   "Arrays in C# are reference types, not value types.",
//   "The method Array.Sort() can be used to sort numbers or strings alphabetically.",
//   "To loop through all elements in an array, you must always use a for loop.",
//   "If you access an array element using an index that doesn’t exist, the program throws an error."
// };

// bool[] answers = {
//   true,
//   false,
//   false,
//   true,
//   true,
//   false,
//   true,
//   true,
//   false,
//   true
// };