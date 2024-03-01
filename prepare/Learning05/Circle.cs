class Circle : Shape
{
    private float _radius;
    private float pi = 3.14159F;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return pi * _radius * _radius;
    }
}