using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class DistanceBetweenPoints
{
    static void Main()
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();
        //Point p1 = new Point() { X = 8, Y = -2 };
        //Point p2 = new Point() { X = -1, Y = 5 };
        double result = CalculateDistance(p1, p2);
        //Console.WriteLine("[{0} {1}]",p1.X, p1.Y);
        //Console.WriteLine("[{0} {1}]",p2.X, p2.Y);
        Console.WriteLine("{0:F3}",result);
    }

    private static Point ReadPoint()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point p = new Point() { X = nums[0], Y = nums[1] };
        return p;
    }

    static double CalculateDistance(Point p1, Point p2)
    {
        double distanceX = Math.Pow(p1.X - p2.X,2);
        double distanceY = Math.Pow(p1.Y - p2.Y, 2);
        double result = Math.Sqrt(distanceX + distanceY);
        return result;
    }
}
