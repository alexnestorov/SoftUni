using System;

class TeleportPoints
{
    static void Main()
    {
        // Get coordinates of x1....x4 and y1...y4
        string pointA = Console.ReadLine();
        string[] A = pointA.Split(' ');
        double x1 = double.Parse(A[0]);
        double y1 = double.Parse(A[1]);
        string pointB = Console.ReadLine();
        string[] B = pointB.Split(' ');
        double x2 = double.Parse(B[0]);
        double y2 = double.Parse(B[1]);
        string pointC = Console.ReadLine();
        string[] C = pointC.Split(' ');
        double x3 = double.Parse(C[0]);
        double y3 = double.Parse(C[1]);
        string pointD = Console.ReadLine();
        string[] D = pointD.Split(' ');
        double x4 = double.Parse(D[0]);
        double y4 = double.Parse(D[1]);

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        int teleportPoints = 0;
        // First part
        for (double x = 0; x <= radius; x += step)
        {
            for (double y = 0; y <= radius; y += step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (((x > x1 && x < x2) && (y < y3 && y > y2)))
                    {
                        teleportPoints++;
                    }
                }
            }
            for (double y = -step; y >= -radius; y -= step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (((x > x1 && x < x2) && (y < y3 && y > y2)))
                    {
                        teleportPoints++;
                    }
                }
            }
        }
        // Second part
        for (double x = -step; x >= -radius; x -= step)
        {
            for (double y = 0; y <= radius; y += step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (((x > x1 && x < x2) && (y < y3 && y > y2)))
                    {
                        teleportPoints++;
                    }
                }
            }
            for (double y = -step; y >= -radius; y -= step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (((x > x1 && x < x2) && (y < y3 && y > y2)))
                    {
                        teleportPoints++;
                    }
                }
            }
        }
        Console.WriteLine(teleportPoints);
    }
}
