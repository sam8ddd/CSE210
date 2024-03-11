using System;
using System.IO;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        int pointTotal = 0;
        List<Goal> goalList = new List<Goal>();

        do
        {
            Console.WriteLine($"\nYou have {pointTotal} points.\n");
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("  1. Create New Goal");
            System.Console.WriteLine("  2. List Goals");
            System.Console.WriteLine("  3. Save Goals");
            System.Console.WriteLine("  4. Load Goals");
            System.Console.WriteLine("  5. Record Event");
            System.Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                System.Console.WriteLine("The types of Goals are:");
                System.Console.WriteLine("  1. Simple Goal");
                System.Console.WriteLine("  2. Eternal Goal");
                System.Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    goalList.Add(new Simple());
                }
                else if (goalType == "2")
                {
                    goalList.Add(new Eternal());
                }
                else if (goalType == "3")
                {
                    goalList.Add(new Checklist());
                }
            }
                
            else if (userChoice == "2")
            {
                for(int i = 0; i < goalList.Count; i++)
                {
                    Console.Write($"{i+1}. ");
                    goalList[i].DisplayGoal();
                }
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(pointTotal);
                    foreach (Goal goal in goalList)
                    {
                        outputFile.WriteLine(goal.ExportGoal());
                    }
                }
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);
                pointTotal = int.Parse(lines[0]);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] chunks = lines[i].Split("::");
                    string[] parts = chunks[1].Split("~");
                    if (chunks[0] == "E")
                    {
                        goalList.Add(new Eternal(parts[0],parts[1],parts[2]));
                    }
                    else if (chunks[0] == "S")
                    {
                        goalList.Add(new Simple(parts[0],parts[1],parts[2],parts[3]));
                    }
                    else if (chunks[0] == "C")
                    {
                        goalList.Add(new Checklist(parts[0],parts[1],parts[2],parts[3],parts[4],parts[5]));
                    }
                }
            }
            else if (userChoice == "5")
            {
                System.Console.WriteLine("The goals are:");
                for (int i = 0; i < goalList.Count; i++)
                {
                    Console.WriteLine($"  {i+1}. {goalList[i].GetGoalTitle()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int goalAccomplished = int.Parse(Console.ReadLine());
                pointTotal += goalList[goalAccomplished-1].RecordEvent();
            }

        } while (userChoice != "6");
    }
}