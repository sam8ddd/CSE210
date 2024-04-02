class RepeatedTask : Task
{
    private int startDay;
    private int endDay;
    private List<bool> areCompleted;

    public RepeatedTask(int timeBlock, int startingDay, int endingDay) : base(timeBlock)
    {
        startDay = startingDay;
        endDay = endingDay;
        areCompleted = new List<bool>(){false,false,false,false,false,false,false};
    }

    public override void Complete(int day)
    {
        areCompleted[day] = true;
    }

    public int GetStartDay()
    {
        return startDay;
    }

    public int GetEndDay()
    {
        return endDay;
    }

    public override void Display(int day)
    {
        if (areCompleted[day])
        {
            Console.WriteLine($"[X] +{name}+: {desc}");
        }
        else
        {
            Console.WriteLine($"[ ] +{name}+: {desc}");
        }
    }
}