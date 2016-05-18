using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOccuriences
{
    static void Main()
    {
        string[] words = Console.ReadLine().ToLower().Split(' ');
        Dictionary<string, int> word = new Dictionary<string, int>();
        List<string> result = new List<string>();
        foreach (var w in words)
        {
            if (word.ContainsKey(w))
            {
               word[w]++;
            }
            else
            {
                word[w] = 1;
            }
        }
        foreach (var item in word)
        {
            if (item.Value % 2 == 1)
            {
                result.Add(item.Key);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }
}
