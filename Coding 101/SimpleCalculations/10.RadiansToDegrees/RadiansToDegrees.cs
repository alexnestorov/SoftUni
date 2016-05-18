using System;

class RadiansToDegrees
{
    static void Main()
    {
        var radians = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Round(radians*180/Math.PI, 2));
    }
}
