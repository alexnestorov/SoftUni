using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceATag
{
    static void Main()
    {
        string htmlText = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        // The input is finished with "end"
        while (htmlText != "end")
        {
            string pattern = @"<a ?href=(""|\')(.+)\1>(\w+)</a>";
            string replacement = @"[URL href=$1$2$1]$3[/URL]";
            Regex rgx = new Regex(pattern);
            result.AppendLine(Regex.Replace(htmlText, pattern, replacement));
                                   
            htmlText = Console.ReadLine();
        }
        Console.Write(result);
    }
}
