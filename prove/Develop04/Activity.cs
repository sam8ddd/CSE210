class Activity
{
    protected int timer;
    protected string activityDescription;
    protected string activityName;

    protected void openMessage()
    {
        Console.Clear();
        System.Console.WriteLine(activityDescription);
        System.Console.Write("How long, in seconds, would you like for your session? ");
        timer = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get Ready...");
        DoSpinner(6);
    }

    protected void closeMessage()
    {
        Console.WriteLine("\nWell done!!");
        DoSpinner(6);
        System.Console.WriteLine("\nYou have completed another 30 seconds of the " + activityName + " Activity.");
        DoSpinner(6);
    }

    protected void DoSpinner(int time)
    {
        List<string> spinChar = new List<string>(){"|","/","-","\\"};

        System.Console.Write(" ");
        for (int i = 0; i < 4*time; i++)
        {
            System.Console.Write("\b"+spinChar[i % 4]);
            Thread.Sleep(250);
        }
        System.Console.Write("\b ");
    }

    protected void DoCountdown(int time)
    {
        System.Console.Write(" ");
        for (int i = time; i > 0; i--)
        {
            System.Console.Write("\b" + i);
            Thread.Sleep(1000);
        }
        Console.Write("\b ");
    }
}