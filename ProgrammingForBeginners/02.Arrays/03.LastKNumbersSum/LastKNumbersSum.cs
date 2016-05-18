using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastKNumbersSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];
        numbers[0] = 1;
        Console.Write(numbers[0]);
        for (int i = 1; i < n; i++)
        {
            long sum = 0;
            for (int prev = i - k; prev <= i - 1; prev++)
            {
                if (prev >= 0)
                {
                    sum += numbers[prev];
                }
            }
            numbers[i] = sum;
            Console.Write(" {0}", numbers[i]);
        }
    }
}
