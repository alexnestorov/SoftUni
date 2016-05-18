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
class ClosestTwoPoints
{
    static void Main()
    {
        Point[] points = ReadPoints();
        Point[] closestPoints = FindClosestTwoPoints(points);
        Console.WriteLine("{0:f3}", CalculateDistance(closestPoints[0], closestPoints[1]));
        PrintPoint(closestPoints[0]);
        PrintPoint(closestPoints[1]);

    }

    private static Point[] FindClosestTwoPoints(Point[] points)
    {
        double minDistance = double.MaxValue;
        Point[] closestTwoPoints = null;
        for (int p1 = 0; p1 < points.Length; p1++)
        {
            for (int p2 = p1 + 1; p2 < points.Length; p2++)
            {
                double distance = CalculateDistance(points[p1], points[p2]);
                if (minDistance > distance)
                {
                    minDistance = distance;
                    closestTwoPoints = new Point[] { points[p1], points[p2] };
                }
            }
        }
        return closestTwoPoints;
    }

    static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];
        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }
        return points;
    }
    private static Point ReadPoint()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point p = new Point() { X = nums[0], Y = nums[1] };
        return p;
    }
    static void PrintPoint(Point point)
    {
        Console.WriteLine("({0}, {1})", point.X, point.Y);
    }
    static double CalculateDistance(Point p1, Point p2)
    {
        double distanceX = Math.Pow(p1.X - p2.X, 2);
        double distanceY = Math.Pow(p1.Y - p2.Y, 2);
        double result = Math.Sqrt(distanceX + distanceY);
        return result;
    }
}
