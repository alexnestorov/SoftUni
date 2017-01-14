using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class QueryMes
{
    static void Main()
    {
        string inputline = Console.ReadLine().Trim('%','+');
        string[] data = inputline.Split('&');
        Console.WriteLine(string.Join("", data));
        string patternKey = @"([a-zA-z0-9]+)(?==)";
        string patternValue = @"(?<==)([a-zA-z0-9]+)";

        Regex rgxKey = new Regex(patternKey);
        Regex rgxValue = new Regex(patternValue);
        MatchCollection matchesKey = rgxKey.Matches(inputline);
        MatchCollection matchesValue = rgxValue.Matches(inputline);

        foreach (Match match in matchesKey)
        {
            Console.WriteLine(match.Groups[1]);
        }
        foreach (Match match in matchesValue)
        {
            Console.WriteLine(match.Groups[1]);
        }
    }
}
