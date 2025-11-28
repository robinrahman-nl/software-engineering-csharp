using System;

namespace LearnInheritance
{
  class Vehicle
  {
    // Properties
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; protected set; }

  // Constructrors
  public Vehicle (double speed)
        {
            this.Speed = speed;
            this.LicensePlate = Tools.GenerateLicensePlate();
        }


    // methods
    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}