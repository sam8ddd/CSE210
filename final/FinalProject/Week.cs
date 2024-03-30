using System.Net;
using System.Reflection;

class Week
{
    private List<Day> days;

    public Week()
    {
        days = new List<Day>();
        for (int i=0; i<7; i++)
        {
            days.Add(new Day());
        }
    }

    public void AddTask(int day)
    {
        days[day].AddNewTask();
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
        days[today].ShowDay(today);
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
            days[i].ShowDay(i);
        }
    }

    public void CompleteTasks(int today)
    {
        Console.Write($"Please pick a day (today is {today}): ");
        int dayChosen = int.Parse(Console.ReadLine());

        days[dayChosen].CompleteTask();
    }
}