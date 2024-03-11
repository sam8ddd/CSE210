class Simple : Goal
{
    private string isChecked = " ";

    public Simple() : base()
    {
        isChecked = " ";
    }

    public Simple(string goalTitle, string goalDesc, string pointValue, string _isChecked) : base(goalTitle, goalDesc, pointValue)
    {
        isChecked = _isChecked;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{isChecked}] {goalTitle} ({goalDesc})");
    }

    public override string ExportGoal()
    {
        return $"S::{goalTitle}~{goalDesc}~{pointValue}~{isChecked}";
    }

    public override int RecordEvent()
    {
        System.Console.WriteLine($"Congratulations! You have earned {pointValue} points!");
        isChecked = "X";
        return pointValue;
    }
}