using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SentenceExtractor
{
    static void Main()
    {
        string patternSentence = @"[A-Z0-9][a-z]*[\w\s\-?'?,?]+[\.|\?|\!]";
        string input = Console.ReadLine();
        StringBuilder text = new StringBuilder();
        while (input != "end")
        {
            text.Append(input);
            input = Console.ReadLine();
        }
        string keyword = Console.ReadLine();
        Regex rgx = new Regex(patternSentence);
        string sentences = text.ToString();
        MatchCollection matches = rgx.Matches(sentences);
        foreach (Match sentence in matches)
        {
            List<string> words = sentence.ToString().Split(' ', '!', '?','.').ToList();
            if (words.Contains(keyword))
            {
                Console.WriteLine(sentence);
            }
        }
        //Console.WriteLine(string.Join(Environment.NewLine, sentences));
    }
}
