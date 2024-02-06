public class Fraction  
{
    private int topNumber;
    private int botNumber;

    public Fraction()
    {
        this.topNumber = 1;
        this.botNumber = 1;
    }

    public Fraction(int topNum)
    {
        this.topNumber = topNum;
        this.botNumber = 1;
    }

    public Fraction(int topNum,int botNum)
    {
        this.topNumber = topNum;
        this.botNumber = botNum;
    }

    public int GetTop()
    {
        return topNumber;
    }

    public void SetTop(int newTop)
    {
        this.topNumber = newTop;
    }

    public int GetBot()
    {
        return botNumber;
    }

    public void setBot(int newBot)
    {
        this.botNumber = newBot;
    }

    public string GetFractionString()
    {
        return $"{topNumber}/{botNumber}";
    }

    public double GetDecimalValue()
    {
        return 1.0*topNumber/botNumber;
    }
}