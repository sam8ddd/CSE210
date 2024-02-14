public class Word
{
    public bool isHidden;
    private string text;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void HideWord()
    {
        isHidden = true;
    }
    public void DisplayWord()
    {
        if (isHidden) // if the word is hidden, then just type '_' for each letter.
        {
            for(int i=0; i < text.Length; i++)
            {
                Console.Write("_");
            }
        }
        else // if the word isn't hidden, then display it
        {
            Console.Write(text);
        }
    }
}