abstract class Shape
{
    string color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public Shape(string _color)
    {
        color = _color;
    }

    public abstract float GetArea();
}