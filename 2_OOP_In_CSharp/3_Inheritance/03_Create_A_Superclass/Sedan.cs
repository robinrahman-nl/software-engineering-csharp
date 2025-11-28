using System;

namespace LearnInheritance
{
  class Sedan : Vehicle
  {
  	
    
    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }
    
   
    
  }
}