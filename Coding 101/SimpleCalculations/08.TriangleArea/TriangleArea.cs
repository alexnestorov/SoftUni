using System;

class TriangleArea
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var area = Math.Round(a * h / 2,2);
        Console.WriteLine("Triangle area = {0}", area);
    }
}
