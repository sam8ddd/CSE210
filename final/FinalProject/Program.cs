using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Week week = new Week();
        int today = (int)DateTime.Now.DayOfWeek;
        string choice;

        System.Console.WriteLine("Welcome to the calendar program! Your hub for all things productive!!! :D");
        
        do
        {
            System.Console.WriteLine("-----------------------------------------");
            System.Console.WriteLine("Please select an option:");
            System.Console.WriteLine("1. Display schedule");
            System.Console.WriteLine("2. Add a new task");
            System.Console.WriteLine("3. Add a new event");
            System.Console.WriteLine("4. Add a new focus time");
            System.Console.WriteLine("5. Add a new repeated task");
            System.Console.WriteLine("6. Add a new repeated event");
            System.Console.WriteLine("7. Complete a task");
            System.Console.WriteLine("q: Quit");
            Console.Write("\nOption: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string numDaysString;
                int numDaysInt;
                Console.Write("How many days to display (type nothing for today)?: ");
                numDaysString = Console.ReadLine();
                if (numDaysString == "")
                {
                    week.ShowOneDay(today);
                }
                else
                {
                    numDaysInt = int.Parse(numDaysString);
                    if (numDaysInt == 7)
                    {
                        week.ShowDays(0,7);
                    }
                    else
                    {
                        Console.Write("Which day to start on?: ");
                        int startDay = int.Parse(Console.ReadLine());
                        week.ShowDays(startDay, numDaysInt);
                    }
                }
                
                
            }
            else if (choice == "2")
            {
                Console.Write($"\nPlease select a day (type nothing for today, {today}): ");
                string dayChosen = Console.ReadLine();
                if (dayChosen == "")
                {
                    week.AddTask(today);
                }
                else
                {
                    week.AddTask(int.Parse(dayChosen));
                }
            }
            else if (choice == "3")
            {
                Console.Write($"\nPlease select a day (type nothing for today, {today}): ");
                string dayChosen = Console.ReadLine();
                if (dayChosen == "")
                {
                    week.AddEvent(today);
                }
                else
                {
                    week.AddEvent(int.Parse(dayChosen));
                }
            }
            else if (choice == "4")
            {
                Console.Write($"\nPlease select a day (type nothing for today, {today}): ");
                string dayChosen = Console.ReadLine();
                if (dayChosen == "")
                {
                    week.AddFocusTime(today);
                }
                else
                {
                    week.AddFocusTime(int.Parse(dayChosen));
                }
            }
            else if (choice == "5")
            {
                week.AddRepeatedTask();
            }
            else if (choice == "6")
            {
                week.AddRepeatedEvent();
            }
            else if (choice == "7")
            {
                week.CompleteTasks(today);
            }
        } while (choice != "q");
    }
}