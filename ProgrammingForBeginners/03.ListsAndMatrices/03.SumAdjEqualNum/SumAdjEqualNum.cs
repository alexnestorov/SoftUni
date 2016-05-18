using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumAdjEqualNum
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        int pos = 0;

        while (pos < numbers.Count - 1)
        {
            if (numbers[pos] == numbers[pos + 1])
            {
                numbers[pos] = numbers[pos] + numbers[pos + 1];
                numbers.RemoveAt(pos + 1);
                pos--;
                if (pos < 0)
                {
                    pos = 0;
                }
            }
            else
            {
                pos++;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
