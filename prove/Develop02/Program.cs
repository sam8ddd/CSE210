using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> promptList = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?","How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?","What am I grateful for today?","What was the most memorable thing about today?"};
        string menuOption;

        System.Console.WriteLine("Welcome to the Journal Program! :)");
        do
        {
            System.Console.WriteLine("Please select one of the following choices:");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            System.Console.Write("What would you like to do? ");
            menuOption = System.Console.ReadLine();

            if (menuOption == "1")
            {
                CreateEntry();
            }
            else if (menuOption == "2")
            {
                journal.DisplayEntries();
            }
            else if (menuOption == "3")
            {
                journal = LoadJournal();
            }
            else if (menuOption == "4")
            {
                SaveJournal();
            }
        } while (menuOption != "5");

        string ShowPrompt()
        {
            Random rnd = new Random();
            int randNum = rnd.Next(promptList.Count);
            System.Console.WriteLine(promptList[randNum]);

            return promptList[randNum];
        }

        void CreateEntry()
        {
            string prompt = ShowPrompt();
            System.Console.Write("> ");
            string response = System.Console.ReadLine();
            DateTime dateTimeLong = DateTime.Now;
            string date = dateTimeLong.ToShortDateString();

            Entry recentEntry = new Entry(prompt, response, date);
            journal.entries.Add(recentEntry);
        }

        void SaveJournal()
        {
            System.Console.WriteLine("What is the filename?");
            string fileName = System.Console.ReadLine();

            List<string> journalString = journal.ExportJournal();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                for(int i=0; i < journalString.Count; i++)
                {
                    outputFile.WriteLine(journalString[i]);
                }
            }
        }

        Journal LoadJournal()
        {
            System.Console.WriteLine("What is the filename?");
            string fileName = System.Console.ReadLine();

            /*
            string[] lines = System.IO.File.ReadAllLines(fileName);
            string[] importedLines = {};
            foreach(string line in lines)
            {
                importedLines = line.Split("|");
            }
            */

            string[] lines = File.ReadAllLines(fileName);
            List<string> importedLines = new List<string>(lines);

            Journal importedJournal = new Journal();
            importedJournal.LoadJournal(importedLines);

            return importedJournal;
        }
    }
}