using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>();
        myShapes.Add(new Square("Red",4));
        myShapes.Add(new Rectangle("Blue",3.1F,2));
        myShapes.Add(new Circle("Green",5.5F));
        
        foreach (Shape currentShape in myShapes)
        {
            Console.WriteLine(currentShape.GetColor());
            Console.WriteLine(currentShape.GetArea());
            Console.Write("\n");
        }
    }
}