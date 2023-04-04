using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeInventory = new List<Shape>();
        Shape s = new Shape("chartreuse green");
        shapeInventory.Add(s);
        Square sq = new Square("vermillion red", 3);
        shapeInventory.Add(sq);
        Rectangle r = new Rectangle("orchid purple",2.2, 5);
        shapeInventory.Add(r);
        Circle c = new Circle("celadon green", 10);
        shapeInventory.Add(c);
        foreach(Shape selected in shapeInventory) {
            Console.WriteLine($"The {selected.getColor()} shape has an area of {selected.getArea()}");
            Console.WriteLine();
        }
    }
}