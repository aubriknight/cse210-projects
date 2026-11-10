using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(4, "Red"));
        shapes.Add(new Rectangle(3, 5, "Blue"));
        shapes.Add(new Circle(2, "Green"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}
