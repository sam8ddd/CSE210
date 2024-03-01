class Rectangle : Shape
{
    private float _height;
    private float _width;

    public Rectangle(string color, float height, float width) : base(color)
    {
        _height = height;
        _width = width;
    }

    public override float GetArea()
    {
        return _height * _width;
    }
}