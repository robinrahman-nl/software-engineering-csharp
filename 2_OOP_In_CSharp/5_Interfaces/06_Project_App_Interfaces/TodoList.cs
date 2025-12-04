using System;

namespace SavingInterface
{
  class TodoList
  {
    // Property: with getter and setter
    public string[] Todos
    { get; private set; }

    // Field: For using inside the class 
    private int nextOpenIndex;

    // Constructor: external classes can add value to this classes properties and so too the fields. 
    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    // Method: public method thats adds a new todo item to the list. 
    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }
  }
}