abstract class Employee
{
 public abstract void SubmitDailyReport();

 public virtual void Work ()
    {
        Console.WriteLine("Emplyee is working");
    }

    public void ClockIn ()
    {
        Console.WriteLine("Emplyee clocks in");
    }
}