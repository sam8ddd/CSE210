using System.Diagnostics.Contracts;

class Day
{
    private List<FocusTime> focusTimes;
    private List<Event> events;
    private List<Task> tasks;
    private List<string> daysList = new List<string>(){"SUNDAY","MONDAY","TUESDAY","WEDNESDAY","THURSDAY","FRIDAY","SATURDAY"};
    private List<int> occupiedTimes;

    public Day()
    {
        focusTimes = new List<FocusTime>();
        events = new List<Event>();
        tasks = new List<Task>();
        occupiedTimes  = new List<int>(){};
    }

    public bool timeIsOccupied(int time)
    {
        foreach(int i in occupiedTimes)
        {
            if (i==time)
            {
                return true;
            }
        }

        return false;
    }

    public List<Task> GetTaskList()
    {
        return tasks;
    }

    public void ShowDay(int today)
    {
        bool wasOccupied;
        bool activeFocusTime = false;
        int activeFocusTimeId = 0;
        System.Console.WriteLine($"\n~ {daysList[today]}'S SCHEDULE: ~");
        for (int i=24; i<=95; i++)
        {
            for (int focus = 0; focus<focusTimes.Count; focus++)
            {
                if (focusTimes[focus].GetStartTime() <= i && focusTimes[focus].GetEndTime() >= i)
                {
                    activeFocusTime = true;
                    activeFocusTimeId = focus;
                    wasOccupied = true;
                }
                else
                {
                    activeFocusTime = false;
                }
            }

            PrintLineIntro(i,activeFocusTime,activeFocusTimeId);

            // populate the schedule with tasks first
            wasOccupied = false;
            foreach(Task task in tasks)
            {
                if (task.DisplayIfOccupied(i))
                {
                    wasOccupied = true;
                }
            }

            // then populate the schedule with events
            List<string> displayLines;
            foreach(Event thisEvent in events)
            {
                if (thisEvent.getStartTime() == i)
                {
                    displayLines = thisEvent.GetDisplayLines();

                    System.Console.WriteLine(displayLines[0]);
                    for (int j=1; j<displayLines.Count; j++)
                    {
                        i++;
                        PrintLineIntro(i,activeFocusTime,activeFocusTimeId);
                        System.Console.WriteLine(displayLines[j]);
                    }

                    wasOccupied = true;
                }
            }

            // if nothing to write on this line
            if (activeFocusTime && !wasOccupied)
            {
                if (focusTimes[activeFocusTimeId].GetStartTime() == i)
                {
                    Console.WriteLine(focusTimes[activeFocusTimeId].GetName());
                }
            }
            else if (i%4==0 && !wasOccupied){Console.WriteLine(" -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");}
            else if(!wasOccupied){Console.Write("\n");}
        }
    }

    private void PrintLineIntro(int i, bool activeFocusTime, int activeFocusTimeId)
    {
        if (i<40 && i%4==0){Console.Write(" ");} // so 9:00 and 10:00 line up
        if (i%4==0){Console.Write($"{i/4}:00 - ");} // if on the hour
        else{Console.Write("      - ");} // if not on the hour
        if (activeFocusTime)
        {
            if (focusTimes[activeFocusTimeId].GetStartTime() <= i && focusTimes[activeFocusTimeId].GetEndTime() >= i)
            {
                Console.Write("* ");
            }
        }
    }

    public void AddNewTask()
    {
        bool invalidTime = true;
        int timeBlock;
        do
        {
            Console.Write("Please select a time (eg 17:15): ");
            string rawTimeChosen = Console.ReadLine();
            string[] timeSplit = rawTimeChosen.Split(":");
            int hours = int.Parse(timeSplit[0]);
            int minutes;
            if (int.Parse(timeSplit[1]) < 15) {minutes = 0;}
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30) {minutes = 1;}
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45) {minutes = 2;}
            else {minutes = 3;}
            timeBlock = 4*hours + minutes;

            if (!timeIsOccupied(timeBlock))
            {
                invalidTime = false;
            }
            else
            {
                System.Console.WriteLine("Time slot is already occupied, try again.");
            }
        } while (invalidTime);

        tasks.Add(new Task(timeBlock));

        occupiedTimes.Add(timeBlock);
    }

    public void AddNewEvent()
    {
        bool invalidTimes = true;
        int startTimeBlock;
        int endTimeBlock;
        do
        {
            Console.Write("Please select a start time (eg 17:15): ");
            string rawStartTime = Console.ReadLine();
            string[] timeSplit = rawStartTime.Split(":");
            int hours = int.Parse(timeSplit[0]);
            int minutes;
            if (int.Parse(timeSplit[1]) < 15) {minutes = 0;}
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30) {minutes = 1;}
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45) {minutes = 2;}
            else {minutes = 3;}
            startTimeBlock = 4*hours + minutes;

            Console.Write("Please select an end time (eg 17:15): ");
            rawStartTime = Console.ReadLine();
            timeSplit = rawStartTime.Split(":");
            hours = int.Parse(timeSplit[0]);
            if (int.Parse(timeSplit[1]) < 15) {minutes = 0;}
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30) {minutes = 1;}
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45) {minutes = 2;}
            else {minutes = 3;}
            endTimeBlock = 4*hours + minutes;

            // check to see if all the occupied time slots are free
            int verifiedTimes = 0;
            for (int i = startTimeBlock; i<=endTimeBlock; i++)
            {
                if (!timeIsOccupied(i))
                {
                    verifiedTimes++;
                }
            }

            if (verifiedTimes == endTimeBlock - startTimeBlock + 1)
            {
                invalidTimes = false;
            }
            else
            {
                System.Console.WriteLine("One or more time slots are already occupied, try again.");
            }
        } while (invalidTimes);

        events.Add(new Event(startTimeBlock,endTimeBlock));

        for (int i = startTimeBlock; i < endTimeBlock; i++)
        {
            occupiedTimes.Add(i);
        }
    }

    public void CompleteTask()
    {
        System.Console.WriteLine("\nTasks:");
        for (int i=0; i<tasks.Count; i++)
        {
            Console.Write($"{i}. ");
            tasks[i].Display();
        }
        System.Console.Write("\nPlease select a task to complete: ");
        int selected = int.Parse(Console.ReadLine());
        tasks[selected].Complete();
    }

    public void AddNewFocusTime()
    {
        int startTimeBlock;
        int endTimeBlock;

        Console.Write("Please select a start time (eg 17:15): ");
        string rawStartTime = Console.ReadLine();
        string[] timeSplit = rawStartTime.Split(":");
        int hours = int.Parse(timeSplit[0]);
        int minutes;
        if (int.Parse(timeSplit[1]) < 15) {minutes = 0;}
        else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30) {minutes = 1;}
        else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45) {minutes = 2;}
        else {minutes = 3;}
        startTimeBlock = 4*hours + minutes;

        Console.Write("Please select an end time (eg 17:15): ");
        rawStartTime = Console.ReadLine();
        timeSplit = rawStartTime.Split(":");
        hours = int.Parse(timeSplit[0]);
        if (int.Parse(timeSplit[1]) < 15) {minutes = 0;}
        else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30) {minutes = 1;}
        else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45) {minutes = 2;}
        else {minutes = 3;}
        endTimeBlock = 4*hours + minutes;

        focusTimes.Add(new FocusTime(startTimeBlock,endTimeBlock));
    }
}