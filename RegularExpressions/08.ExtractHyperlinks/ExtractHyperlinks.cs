using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractHyperlinks
{
    static void Main()
    {
        string pattern = //@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
                       @"<a\s+[\w='"",()\-\s]*href\s*=\s*(""|'|)?([^'""\s>]+)\1[\w=""'&()\s]*(&lt;a|[<\/a>])";
                       //@"<a\s+[\w='"",()\-\s]*href\s*=\s*(""|'|)?([\w\.#:'"" /=()!\-\s]+)\1>[0-z'"" #\-\!(),%&]*/a>";
        string input = Console.ReadLine();
        StringBuilder text = new StringBuilder();
        while (input != "END")
        {
            text.Append(input);
            input = Console.ReadLine();
        }
        //Console.WriteLine("-----------------------");
        //Console.WriteLine(text);
        Regex rgx = new Regex(pattern);
        string sentences = text.ToString();
        MatchCollection matches = rgx.Matches(sentences);
        //string[] valid = Regex.Split(sentences, @"<li>|</li>|<ul>|</ul>");
        int count = 0;
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[2]);
        }
    }
}
