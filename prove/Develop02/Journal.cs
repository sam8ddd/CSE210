using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    
    public void DisplayEntries()
    {
        foreach(Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        entries.Add(newEntry);
    }

    public void ExportJournal()
    {
        System.Console.WriteLine("What is the filename?");
        string fileName = System.Console.ReadLine();
        System.Console.WriteLine("What is YOUR name, friend?");
        string userName = System.Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        foreach(Entry entry in entries)
        {
            List<string> currentEntry = entry.ExportEntry();
            System.Console.WriteLine($"currentEntry: {currentEntry}");
            outputFile.WriteLine(currentEntry[0]);
            outputFile.WriteLine(currentEntry[1]);
            outputFile.WriteLine(currentEntry[2]);
            outputFile.WriteLine(userName);
        }
    }

    public void LoadJournal(List<string> importedLines)
    {
        for(int i = 0; i*4 < importedLines.Count; i++)
        {
            Entry importedEntry = new Entry(importedLines[4*i],importedLines[4*i+1],importedLines[4*i+2]);
            entries.Add(importedEntry);
        }
        System.Console.WriteLine($"\nWelcome back, {importedLines[3]}. I'm glad to see you again!\n");
    }
}