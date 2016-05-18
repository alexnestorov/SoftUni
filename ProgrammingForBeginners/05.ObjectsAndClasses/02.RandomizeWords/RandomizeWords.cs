using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeWords
{
    static void Main(string[] args)
    {
        var elements = Console.ReadLine().Split(' ').ToList();
        Random rnd = new Random();
        List<string> result = new List<string>();

        while (elements.Count > 0)
        {
            var random = rnd.Next(0, elements.Count);
            result.Add(elements[random]);
            elements.RemoveAt(random);
        }
        Console.WriteLine(string.Join("\r\n", result));
    }
}
