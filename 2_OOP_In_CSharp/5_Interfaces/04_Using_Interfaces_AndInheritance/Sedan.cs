using System;

namespace LearnInterfaces
{
  class Sedan : Vehicle, IAutomobile
  {
  
    
  }
}


// 1. Update the definition of Sedan so that it also inherits from the Vehicle class. Remove all the members defined within Vehicle from the definition of the Sedan class.

// 2. Even though Sedan no longer directly implements the members of IAutomobile, it inherits them all from Vehicle, meaning it still fulfills the requirements of the interface!
//    Run your code again when you are ready to move on.

