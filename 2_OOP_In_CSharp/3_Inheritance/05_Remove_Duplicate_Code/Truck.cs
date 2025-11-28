using System;

namespace LearnInheritance

{
  // 1. Make Truck inherit from Vehicle:
  class Truck : Vehicle
  {
       
    public double Weight
    { get; }

    public Truck(double speed, double weight)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }
    
 

  

   

  }
}