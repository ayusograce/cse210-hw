using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square sq = new Square("black", 5);
        Rectangle rec = new Rectangle("pink", 3.5, 1);
        Circle cir = new Circle("white", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"\nThe color is {color} and the area is {area}");
        }

    }
}