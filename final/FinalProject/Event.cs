using System.ComponentModel;

class Event
{
    protected string name;
    protected string desc;
    protected int startTime;
    protected int endTime;

    public Event(int startTimeBlock, int endTimeBlock)
    {
        startTime = startTimeBlock;
        endTime = endTimeBlock;

        Console.Write("Event Name: ");
        name = Console.ReadLine();
        Console.Write("Event Description: ");
        desc = Console.ReadLine();
    }

    public int getStartTime()
    {
        return startTime;
    }

    public virtual List<string> GetDisplayLines()
    {
        List<string> displayLines = new List<string>(){$"| {name}:",$"| {desc}"};
        for(int i = 0; i<(endTime-startTime)-2; i++)
        {
            displayLines.Add("|");
        }

        return displayLines;
    }
}