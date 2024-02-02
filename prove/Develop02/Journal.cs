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

        using (StreamWriter outputFile = new StreamWriter(fileName))
        foreach(Entry entry in entries)
        {
            List<string> currentEntry = entry.ExportEntry();
            System.Console.WriteLine($"currentEntry: {currentEntry}");
            outputFile.WriteLine(currentEntry[0]);
            outputFile.WriteLine(currentEntry[1]);
            outputFile.WriteLine(currentEntry[2]);
        }
    }

    public void LoadJournal(List<string> importedLines)
    {
        for(int i = 0; i*3 < importedLines.Count; i++)
        {
            Entry importedEntry = new Entry(importedLines[3*i],importedLines[3*i+1],importedLines[3*i+2]);
            entries.Add(importedEntry);
        }
    }
}