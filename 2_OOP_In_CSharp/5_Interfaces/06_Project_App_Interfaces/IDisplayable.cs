// Define IDisplayable in this file

using System;

namespace SavingInterface
{
    // 2.  
    // In IDisplayable.cs, define an empty IDisplayable interface.
    interface IDisplayable
    {
        // 3. declare one method that: 
        // is named Display().  returns nothing
        void Display ();

        // 13. additional challange
        string HeaderSymbol { get;}
    }
    
    

}