using System;

namespace SavingInterface 
{
  class TodoList : IDisplayable, IResetable
  {
    public string HeaderSymbol { get { return "_";} }

    // Property: with getter and setter
    public string[] Todos
    { get; private set; }

    // Field: For using inside the class 
    private int nextOpenIndex;

    // Constructor: external classes can add value to this classes properties 
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

    // 5. The class must actually implement the interface by defining a Display() method.
    public void Display()


    {

      foreach (var item in Todos)
      {
        Console.WriteLine(item);
      }
    }

    public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
  }
}