class Intern : Employee
{
    public override void Work ()
    {
        Console.WriteLine("Intern assists with the project.");
    }

    // 8. 
    public override void SubmitDailyReport()
    {
        Console.WriteLine("Intern submits daily report.");
    }
}