public class Entry
{
    public string prompt;
    public string response;
    public string date;
    List<string> promptList = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?","How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?","What am I grateful for today?","What was the most memorable thing about today?"};

    public Entry(string _prompt, string _response, string _date)
    {
        prompt = _prompt;
        response = _response;
        date = _date;
    }

    public Entry()
    {
        string promptIn = ShowPrompt();
        System.Console.Write("> ");
        string responseIn = System.Console.ReadLine();
        DateTime dateTimeLong = DateTime.Now;
        string dateIn = dateTimeLong.ToShortDateString();

        this.prompt = promptIn;
        this.response = responseIn;
        this.date = dateIn;
    }

    string ShowPrompt()
    {
        Random rnd = new Random();
        int randNum = rnd.Next(promptList.Count);
        System.Console.WriteLine(promptList[randNum]);

        return promptList[randNum];
    }

    public List<string> ExportEntry()
    {
        return new List<string>() {prompt, response, date};
    }

    public void DisplayEntry()
    {
        System.Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        System.Console.WriteLine(response+"\n");
        System.Console.WriteLine("");
    }
}