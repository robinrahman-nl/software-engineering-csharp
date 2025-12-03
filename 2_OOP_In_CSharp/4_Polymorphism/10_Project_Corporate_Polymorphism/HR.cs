class HR : Employee
{
    public override void SubmitDailyReport()
    {
        Console.WriteLine("Hr submits daily report.");
    }

    public override void Work()
    {
        Console.WriteLine("HR handles employee matters");
    }
}  