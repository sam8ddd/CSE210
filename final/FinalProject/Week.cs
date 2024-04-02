using System.Net;
using System.Reflection;

class Week
{
    private List<Day> days;
    private List<RepeatedTask> repeatedTasks;
    private List<RepeatedEvent> repeatedEvents;

    public Week()
    {
        days = new List<Day>();
        repeatedTasks = new List<RepeatedTask>();
        repeatedEvents = new List<RepeatedEvent>();
        for (int i=0; i<7; i++)
        {
            days.Add(new Day());
            days[i].dayIdx = i;
        }
    }

    public void AddTask(int day)
    {
        days[day].AddNewTask();
    }

    public void AddRepeatedTask()
    {
        bool invalidTime = true;
        int timeBlock;
        int startDay;
        int endDay;

        do
        {
            Console.Write("Please select a start day (0 for Sunday): ");
            startDay = int.Parse(Console.ReadLine());
            Console.Write("Please select an end day (6 for Saturday): ");
            endDay = int.Parse(Console.ReadLine());

            Console.Write("Please select a time (eg 17:15): ");
            string rawTimeChosen = Console.ReadLine();
            string[] timeSplit = rawTimeChosen.Split(":");
            int hours = int.Parse(timeSplit[0]);
            int minutes;
            if (int.Parse(timeSplit[1]) < 15)
            {
                minutes = 0;
            }
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30)
            {
                minutes = 1;
            }
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45)
            {
                minutes = 2;
            }
            else
            {
                minutes = 3;
            }
            timeBlock = 4*hours + minutes;

            int numValidTimes = 0;
            for (int i=startDay; i<=endDay; i++)
            {
                if (!days[i].timeIsOccupied(timeBlock))
                {
                    numValidTimes++;
                }
            }
            if (numValidTimes == endDay-startDay+1)
            {
                invalidTime = false;
            }
            else
            {
                System.Console.WriteLine("One or more days has this time slot occupied, try again.");
            }
        } while (invalidTime);

        repeatedTasks.Add(new RepeatedTask(timeBlock,startDay,endDay));

        for (int i=startDay; i<=endDay; i++)
        {
            days[i].addToOccupiedTimes(timeBlock);
        }
    }

    public void AddRepeatedEvent()
    {
        bool invalidTimes = true;
        int startTimeBlock;
        int endTimeBlock;
        int startDay;
        int endDay;
        do
        {
            Console.Write("Please select a start day (0 for Sunday): ");
            startDay = int.Parse(Console.ReadLine());
            Console.Write("Please select an end day (6 for Saturday): ");
            endDay = int.Parse(Console.ReadLine());

            Console.Write("Please select a start time (eg 17:15): ");
            string rawStartTime = Console.ReadLine();
            string[] timeSplit = rawStartTime.Split(":");
            int hours = int.Parse(timeSplit[0]);
            int minutes;
            if (int.Parse(timeSplit[1]) < 15)
            {
                minutes = 0;
            }
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30)
            {
                minutes = 1;
            }
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45)
            {
                minutes = 2;
            }
            else
            {
                minutes = 3;
            }
            startTimeBlock = 4*hours + minutes;

            Console.Write("Please select an end time (eg 17:15): ");
            rawStartTime = Console.ReadLine();
            timeSplit = rawStartTime.Split(":");
            hours = int.Parse(timeSplit[0]);
            if (int.Parse(timeSplit[1]) < 15)
            {
                minutes = 0;
            }
            else if (int.Parse(timeSplit[1]) >= 15 && int.Parse(timeSplit[1]) < 30)
            {
                minutes = 1;
            }
            else if (int.Parse(timeSplit[1]) >= 30 && int.Parse(timeSplit[1]) < 45)
            {
                minutes = 2;
            }
            else
            {
                minutes = 3;
            }
            endTimeBlock = 4*hours + minutes;

            int numValidDays = 0;
            int numValidTimes = 0;
            for (int day=startDay; day<=endDay; day++)
            {
                numValidTimes = 0;
                for (int time=startTimeBlock; time<=endTimeBlock; time++)
                {
                    if (!days[day].timeIsOccupied(time))
                    {
                        numValidTimes++;
                    }
                }

                if (numValidTimes == endTimeBlock-startTimeBlock+1)
                {
                    numValidDays++;
                }
            }

            if (numValidDays == endDay-startDay+1)
            {
                invalidTimes = false;
            }

            if (invalidTimes)
            {
                System.Console.WriteLine("One or more of the desired time slots are already taken, try again.");
            }
        } while(invalidTimes);

        repeatedEvents.Add(new RepeatedEvent(startTimeBlock,endTimeBlock,startDay,endDay));

        for (int day=startDay; day<=endDay; day++)
        {
            for (int time=startTimeBlock; time<=endTimeBlock; time++)
            {
                days[day].addToOccupiedTimes(time);
            }
        }
    }

    public void AddEvent(int day)
    {
        days[day].AddNewEvent();
    }

    public void AddFocusTime(int day)
    {
        days[day].AddNewFocusTime();
    }

    public void ShowOneDay(int today)
    {
        days[today].ShowDay(today,repeatedTasks,repeatedEvents);
    }

    public void ShowDays(int startDay, int numDays)
    {
        int endDay;
        if (startDay + numDays > 7)
        {
            endDay = 7;
        }
        else
        {
            endDay = startDay + numDays;
        }

        for (int i=startDay; i<endDay; i++)
        {
            days[i].ShowDay(i,repeatedTasks,repeatedEvents);
        }
    }

    public void CompleteTasks(int today)
    {
        Console.Write($"\nPlease select a day (type nothing for today, {today}): ");
        string dayChosen = Console.ReadLine();
        if (dayChosen == "")
        {
            days[today].CompleteTask(today,repeatedTasks);
        }
        else
        {
            days[int.Parse(dayChosen)].CompleteTask(today,repeatedTasks);
        }
    }
}