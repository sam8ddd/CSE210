class Checklist : Goal
{
    private int bonusPoints;
    private int timesCompleted;
    private int bonusThreshold;

    public Checklist() : base()
    {
        timesCompleted = 0;
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        bonusThreshold = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
    }

    public Checklist(string goalTitle, string goalDesc, string pointValue, string _bonusPoints, string _timesCompleted, string _bonusThreshold) : base(goalTitle, goalDesc, pointValue)
    {
        bonusPoints = int.Parse(_bonusPoints);
        timesCompleted = int.Parse(_timesCompleted);
        bonusThreshold = int.Parse(_bonusThreshold);
    }

    public override void DisplayGoal()
    {
        if (timesCompleted >= bonusThreshold)
        {
            Console.WriteLine($"[X] {goalTitle} ({goalDesc}) -- Currently Completed: {timesCompleted}/{bonusThreshold}");
        }
        else
        {
            Console.WriteLine($"[ ] {goalTitle} ({goalDesc}) -- Currently Completed: {timesCompleted}/{bonusThreshold}");
        }
    }

        public override int RecordEvent()
    {
        timesCompleted++;
        if (timesCompleted == bonusThreshold)
        {
            System.Console.WriteLine($"Congratulations! You have earned {pointValue + bonusPoints} points!");
            return pointValue + bonusPoints;
        }
        else
        {
            System.Console.WriteLine($"Congratulations! You have earned {pointValue} points!");
            return pointValue;
        }
        
    }

    public override string ExportGoal()
    {
        return $"C::{goalTitle}~{goalDesc}~{pointValue}~{bonusPoints}~{timesCompleted}~{bonusThreshold}~";
    }
}