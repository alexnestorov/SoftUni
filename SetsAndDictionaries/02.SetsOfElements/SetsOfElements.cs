using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SetsOfElements
{
    static void Main()
    {
        int[] size = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
        int n = size[0];
        int m = size[1];
        var firstHashSet = new HashSet<int>();
        var secondHashSet = new HashSet<int>();
        AddNumbers(n, firstHashSet);
        AddNumbers(m, secondHashSet);
        foreach (var number in firstHashSet)
        {
            if (secondHashSet.Contains(number))
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }

    static void AddNumbers(int n, HashSet<int> firstHashSet)
    {
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            firstHashSet.Add(number);
        }
    }
}
