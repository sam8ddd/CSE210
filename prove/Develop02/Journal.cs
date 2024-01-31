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

    public List<string> ExportJournal()
    {
        List<string> journalString = new List<string>();
        foreach(Entry entry in entries)
        {
            List<string> entryData = entry.ExportEntry();
            journalString.Add(entryData[0]);
            journalString.Add(entryData[1]);
            journalString.Add(entryData[2]);
        }
        return journalString;
    }

    public void LoadJournal(List<string> importedLines)
    {
        for(int i = 0; i*3 < importedLines.Count; i++)
        {
            System.Console.WriteLine($"importedLines.Count: {importedLines.Count}");
            System.Console.WriteLine($"i: {i}");
            Entry importedEntry = new Entry(importedLines[3*i],importedLines[3*i+1],importedLines[3*i+2]);
            entries.Add(importedEntry);
        }
    }
}