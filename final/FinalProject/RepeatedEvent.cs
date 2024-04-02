class RepeatedEvent : Event
{
    private int startDay;
    private int endDay;

    public RepeatedEvent(int startTimeBlock, int endTimeBlock, int startingDay, int endingDay) : base(startTimeBlock,endTimeBlock)
    {
        startDay = startingDay;
        endDay = endingDay;
    }

    public int GetStartDay()
    {
        return startDay;
    }

    public int GetEndDay()
    {
        return endDay;
    }

    public override List<string> GetDisplayLines()
    {
        List<string> displayLines = new List<string>(){$"| +{name}+:",$"| {desc}"};
        for(int i = 0; i<(endTime-startTime)-2; i++)
        {
            displayLines.Add("|");
        }

        return displayLines;
    }
}