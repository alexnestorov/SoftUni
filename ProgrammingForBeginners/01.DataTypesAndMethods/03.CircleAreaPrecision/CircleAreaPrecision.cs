using System;

class CircleAreaPrecision
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double circleArea = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("{0:F12}", circleArea);
    }
}
