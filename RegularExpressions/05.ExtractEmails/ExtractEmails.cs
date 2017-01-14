using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main()
    {
        // Pattern for e-mail address in format worddigit.-_worddigit@word.-word.word
        string pattern = @"^([A-Za-z0-9])([A-Za-z0-9\.\-_]+)(@([a-z]+[\.\-a-z]*)+)(\.[a-z]{1,})$";
        Regex rgx = new Regex(pattern);
        string input = Console.ReadLine().TrimEnd('.');
        List<string> result = new List<string>();

        while (input != "end")
        {
            string[] words = input.Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var word in words)
            {
                if (rgx.IsMatch(word))
                {
                    result.Add(word);
                }
            }
            input = Console.ReadLine().TrimEnd('.');
        }
        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}
