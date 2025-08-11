using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shape = new List<Shapes>();

        Square s1 = new Square("Yellow", 5);
        shape.Add(s1);

        Rectangle s2 = new Rectangle("White", 6, 7);
        shape.Add(s2);

        Circle s3 = new Circle("Red", 9);
        shape.Add(s3);

        foreach (Shapes s in shape)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}