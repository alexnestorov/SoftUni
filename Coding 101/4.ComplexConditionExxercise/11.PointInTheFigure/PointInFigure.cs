using System;

class PointInFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int x1 = 0; int x2 = 3 * h; int y1 = 0; int y2 = h;     // Coordinates first rectangle //
        int x3 = h; int x4 = 2 * h; int y3 = h; int y4 = 4 * h;     // Coordinates second rectangle //
        
            // Check point is in both rectangles //
        bool isInside = ((x > x1 && x < x2 && y > y1 && y < y2) || (x > x3 && x < x4 && y > y3 && y < y4));
        bool additionalCheck = (y == y3 && x > x3 && x < x4);

            // Check point is in border of both rectangles //
        bool isBorder = (((x == x1 || x == x2) && (y >= y1) && (y <= y2)) || ((y == y1 || y == y2) && (x >= x1) && (x <= x2))
            || (((x == x3 || x == x4) && (y >= y3) && (y <= y4)) || ((y == y3 || y == y4) && (x >= x3) && (x <= x4))));

        if (isInside || additionalCheck)
        {
            Console.WriteLine("inside");
        }
        else if (isBorder)
        {
            Console.WriteLine("border");
        }
        else if (!isInside)
        {
            Console.WriteLine("outside");
        }
    }
}