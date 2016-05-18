using System;

class TriangleArea
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        double side = Math.Abs(x2 - x3);
        double h = Math.Abs(y1 - y3);

        double area = side * h / 2;
        Console.WriteLine(area);

    }
}
