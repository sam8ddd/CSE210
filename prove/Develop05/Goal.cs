class Goal
{
    protected int pointValue;
    protected string goalTitle;
    protected string goalDesc;

    public Goal()
    {
        System.Console.Write("What is the name of your goal? ");
        goalTitle = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        goalDesc = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        pointValue = int.Parse(Console.ReadLine());
    }

    public Goal(string _goalTitle, string _goalDesc, string _pointValue)
    {
        goalTitle = _goalTitle;
        goalDesc = _goalDesc;
        pointValue = int.Parse(_pointValue);
    }

    public string GetGoalTitle()
    {
        return goalTitle;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {goalTitle} ({goalDesc})");
    }

    public virtual int RecordEvent()
    {
        System.Console.WriteLine($"Congratulations! You have earned {pointValue} points!");
        return pointValue;
    }

    public virtual string ExportGoal()
    {
        return $"E::{goalTitle}~{goalDesc}~{pointValue}";
    }
}