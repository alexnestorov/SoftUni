using System;

class Sum
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int min = Math.Min(Math.Min(first, second), third);
        int max = Math.Max(Math.Max(first, second), third);

        int sum = first + second + third;
        int middle = sum - min - max;

        if (min + middle == max)
        {
            Console.WriteLine("{0} + {1} = {2}", min, middle, max);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
