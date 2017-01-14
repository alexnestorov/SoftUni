using System;
using System.Collections.Generic;

class CountSymbols
{
    static void Main()
    {
        var symbols = new SortedDictionary<char, int>();
        string text = Console.ReadLine();

        foreach (var ch in text)
        {
            if (symbols.ContainsKey(ch))
            {
                symbols[ch]++;
            }
            else
            {
                symbols.Add(ch, 1);
            }
        }
        foreach (var symbol in symbols)
        {
            Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
        }
    }
}
