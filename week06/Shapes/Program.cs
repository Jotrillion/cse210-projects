using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4.0);


        Console.WriteLine($"Square Color: {square.GetColor()}, Side: {square.GetSide()}, Area: {square.GetArea()}");
        Circle circle = new Circle("Blue", 3.0);
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Radius: {circle.GetRadius()}, Area: {circle.GetArea()}");
        Rectangular rectangular = new Rectangular("Green", 5.0, 10.0);
        Console.WriteLine($"Rectangular Color: {rectangular.GetColor()}, Length: {rectangular.GetLength()}, Width: {rectangular.GetWidth()}, Area: {rectangular.GetArea()}");
        List<Shape> shapes = new List<Shape> { square, circle, rectangular };
        double totalArea = 0.0;
        foreach (Shape shape in shapes)
        {
            totalArea += shape.GetArea();
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
        Console.WriteLine($"Total Area: {totalArea}");
    }
}