public class Entry
{
    public string prompt;
    public string response;
    public string date;

    public Entry(string _prompt, string _response, string _date)
    {
        prompt = _prompt;
        response = _response;
        date = _date;
    }

    public List<string> ExportEntry()
    {
        List<string> entryPackage = new List<string>() {prompt, response, date};
        return entryPackage;
    }

    public void DisplayEntry()
    {
        System.Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        System.Console.WriteLine(response);
        System.Console.WriteLine("");
    }
}