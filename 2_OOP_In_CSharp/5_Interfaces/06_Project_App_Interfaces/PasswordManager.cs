using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    public string HeaderSymbol
    {
      get { return "#";}
    }
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    // Constructor: 
    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }


    // 6. Repeat nr. 5. 
    public void Display()
    {
      // Print Header 5 times
      for (int i=0; i<5; i++ ) {Console.Write(HeaderSymbol);}
      Console.WriteLine();


      if (Hidden)
        {
          Console.WriteLine(Password);
        }
        else
        {
          Console.WriteLine("****");
        }
    }

    // 11. Define a Reset() method to satisfy the interface. It should set Password to an empty string and set Hidden to false.
    public void Reset()
    {
      Password = "";
      Hidden = false;
    }


  }
}