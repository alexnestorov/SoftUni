using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintReceipt
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double sum = 0.0;
        Console.WriteLine("/----------------------\\");
        foreach (var num in nums)
        {
            Console.WriteLine("|{0,21:F2} |", num);
            sum += num;
        }
        Console.WriteLine("|----------------------|");
        Console.WriteLine("| Total:{0, 14:F2} |", sum);
        Console.WriteLine("\\----------------------/");
    }
}
