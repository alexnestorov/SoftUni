using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(num.Sum());
        Console.WriteLine(num.Min());
        Console.WriteLine(num.Max());
        Console.WriteLine(num.First());
        Console.WriteLine(num.Last());
        Console.WriteLine(num.Average());
    }
}
