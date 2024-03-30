class FocusTime
{
    protected string name;
    protected int startTime;
    protected int endTime;

    public FocusTime(int startTimeBlock, int endTimeBlock)
    {
        startTime = startTimeBlock;
        endTime = endTimeBlock;

        Console.Write("Focus Time Name: ");
        name = Console.ReadLine();
    }

    public int GetStartTime()
    {
        return startTime;
    }

    public int GetEndTime()
    {
        return endTime;
    }

    public string GetName()
    {
        return name;
    }

    public virtual void Display()
    {
        
    }
}