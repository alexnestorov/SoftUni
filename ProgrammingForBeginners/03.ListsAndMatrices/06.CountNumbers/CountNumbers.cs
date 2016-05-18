using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbers.Sort();
        int count = 1;
        if (numbers.Count == 1)
        {
            Console.WriteLine("{0} -> {1}", numbers[0], count);
        }
        else
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (i == numbers.Count - 2)
                    {
                        Console.WriteLine("{0} -> {1}", numbers[i + 1], count);
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], count);
                    count = 1;
                }
                if (numbers[i] != numbers[i + 1] && i == numbers.Count - 2)
                {
                    Console.WriteLine("{0} -> {1}", numbers[i + 1], count);
                }
            }
        }
    }
}
