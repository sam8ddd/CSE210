public class Reference
{
    private string book;
    private string chapter;
    private string verse;

    public Reference(string book, string chapter, string verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }

    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = $"{verseStart}-{verseEnd}";
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{book} {chapter}:{verse}");
    }
}