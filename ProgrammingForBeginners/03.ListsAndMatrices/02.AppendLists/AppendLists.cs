using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppendLists
{
    static void Main()
    {
        List<string> listNumbers = Console.ReadLine().Split('|').ToList();
        List<string> result = new List<string>();
        for (int i = listNumbers.Count - 1; i >= 0; i--)
        {
            var currentList = listNumbers[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var list in currentList)
            {
                result.Add(list);
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
