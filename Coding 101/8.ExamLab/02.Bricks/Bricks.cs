using System;

class Bricks
{
    static void Main()
    {
        double bricks = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());
        double maxBricks = double.Parse(Console.ReadLine());

        double bricksN = maxBricks * workers;
        double result = Math.Ceiling(bricks / bricksN);
        Console.WriteLine(result);
    }
}

