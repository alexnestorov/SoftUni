using System;

class GenerateRectangles
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int count = 0;
        for (int left = -a; left <= a; left++)
        {
            for (int top = -a; top <= a; top++)
            {
                for (int right = left + 1; right <= a; right++)
                {
                    for (int bottom = top + 1; bottom <= a; bottom++)
                    {
                        int width = right - left;
                        int height = bottom - top;
                        int area = width * height;
                        if (area >= m)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", top, left, bottom, right, area);
                            count++;
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
