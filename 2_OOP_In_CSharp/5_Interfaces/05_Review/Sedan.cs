using System;

namespace LearnInterfaces
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
    
  }
}