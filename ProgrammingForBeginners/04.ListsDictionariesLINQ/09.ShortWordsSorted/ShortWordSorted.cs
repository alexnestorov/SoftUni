using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShortWordSorted
{
    static void Main()
    {
        char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '!', '?', ' ' };
        string[] words = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < 5 && !(result.Contains(words[i])))
            {
                result.Add(words[i]);
            }
        }
        result.Sort();
        Console.WriteLine(string.Join(", ", result));
    }
}
