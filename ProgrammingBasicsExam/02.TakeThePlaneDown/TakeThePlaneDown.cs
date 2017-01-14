using System;

class TakeThePlaneDown
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int distanceToBorder = int.Parse(Console.ReadLine());
        int planeNumbers = int.Parse(Console.ReadLine());

        for (int count = 1; count <= planeNumbers; count++)
        {
            int planeX = int.Parse(Console.ReadLine());
            int planeY = int.Parse(Console.ReadLine());
            double crashPlane = Math.Sqrt((planeX - x) * (planeX - x) + (planeY - y) * (planeY - y));
            if (crashPlane <= distanceToBorder)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
            }
        }
    }
}
