using System;

class PointInFigure
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool isInsideLeft = (x >= 2) && (x <= 12) && (y >= -3) && (y <= 1);
        bool isInsideRight = (x >= 4) && (x <= 10) && (y >= -5) && (y <= 3);

        if (isInsideLeft || isInsideRight)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}
