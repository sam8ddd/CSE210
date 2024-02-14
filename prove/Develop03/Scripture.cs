using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private int numBlankedWords;
    private int blankStep = 3; // number of words to erase each time
    private bool _isAllBlank = false;

    // this constructor is for just a single verse
    public Scripture()
    {
        this.reference = new Reference("John", "3", "16");
        numBlankedWords = 0;
        words = new List<Word> {new Word("For"), new Word("God"), new Word("so"), new Word("loved"), new Word("the"), new Word("world,"), new Word("that"), new Word("He"), new Word("gave"), new Word("His"), new Word("only"), new Word("Begotten"), new Word("Son,"), new Word("that"), new Word("whosoever"), new Word("believeth"), new Word("in"), new Word("Him"), new Word("should"), new Word("not"), new Word("perish,"), new Word("but"), new Word("have"), new Word("everlasting"), new Word("life.")};
    }

    // this constructor is for two or more verses!
    private void EraseWords()
    {
        Random rnd = new Random();
        for (int i=0; i < blankStep; i++)
        {
            int blankIdx = rnd.Next(0,words.Count);

            // if there are still words to blank but this one is hidden, then keep going
            if (words[blankIdx].isHidden && numBlankedWords < words.Count)
            {
                i--;
            }
            // otherwise, make it blank and progress the loop. if all words are blank,
            // the loop run the test of its course without effect
            else
            {
                words[blankIdx].HideWord();
                numBlankedWords++;
            }
        }

        if (numBlankedWords >= words.Count)
        {
            // hello code grader! I hope you are having a great day! Know you are valued, loved, and appreciated.
            // People are happy that you're in their life! Take time for self-care, champ! Take a break when needed.
            // :)
            _isAllBlank = true;
        }
    }

    // this is just a get function
    public bool IsAllBlank()
    {
        return _isAllBlank;
    }

    public void DisplayScripture()
    {
        reference.DisplayReference();

        foreach(Word word in words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }

        EraseWords(); // after displaying the scripture, blank some of the words for the next iteration
    }
}