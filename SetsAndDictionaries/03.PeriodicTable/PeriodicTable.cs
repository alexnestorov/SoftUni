using System;
using System.Collections.Generic;
using System.Linq;

class PeriodicTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var chemicals = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
            foreach (var ch in input)
            {
                chemicals.Add(ch);
            }
        }
        var sortedChemicals = chemicals.OrderBy(x => x);
        Console.WriteLine(string.Join(" ", chemicals));

    }
}
