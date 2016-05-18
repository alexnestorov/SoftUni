using System;

class PointInFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int x1 = 0; int x2 = 3 * h; int y1 = 0; int y2 = h;
        int x3 = h; int x4 = 2 * h; int y3 = h; int y4 = 4 * h;

        // Inside check
        bool isFirstRectangle = (x > x1 && x < x2) && (y > y1 && y < y2);
        bool isSecondRectangle = (x > x3 && x < x4) && (y > y3 && y < y4);
        bool additionalCheck = ((x > h) && (x < 2 * h) && (y == h));

        // Border check
        bool isFirstBorder = ((x == x1 || x == x2) && (y >= y1) && (y <= y2)) ||
            (y == y1 || y == y2) && (x >= x1) && (x <= x2);
        bool isSecondBorder = ((x == x3 || x == x4) && (y >= y3) && (y <= y4)) ||
            (y == y3 || y == y4) && (x >= x3) && (x <= x4);

        if ((isFirstRectangle || isSecondRectangle) || additionalCheck)
        {
            Console.WriteLine("inside");
        }
        else if ((isFirstBorder || isSecondBorder))
        {
            Console.WriteLine("border");

        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
