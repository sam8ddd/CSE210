using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string menuOption = "1";

        System.Console.WriteLine("Welcome to the Journal Program! :)");
        do
        {
            if (menuOption != "2")
            {
                Console.Clear();
            }

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
                journal.AddEntry();
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
                journal.ExportJournal();
            }
        } while (menuOption != "5");

        Journal LoadJournal()
        {
            System.Console.WriteLine("What is the filename?");
            string fileName = System.Console.ReadLine();

            string[] lines = File.ReadAllLines(fileName);
            List<string> importedLines = new List<string>(lines);

            Journal importedJournal = new Journal();
            importedJournal.LoadJournal(importedLines);

            return importedJournal;
        }
    }
}