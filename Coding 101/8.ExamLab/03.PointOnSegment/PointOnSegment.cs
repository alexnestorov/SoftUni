using System;

class PointOnSegment
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int min = Math.Min(first, second);
        int max = Math.Max(first, second);

        int result = Math.Min(Math.Abs(min - point), Math.Abs(max - point));
        if (point >= min && point <= max)
        {
            Console.WriteLine("in");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out");
            Console.WriteLine(result);
        }
    }
}
