using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static void Main()
    {
        string text =  Console.ReadLine(); //"aaaaabbbbbcdddeeeedssaaSSSSSSSSSSSSZZZZZZZZZZZZZ";
        string pattern = @"([A-z])\1+";
        string replacement = "$1";
        Regex rgx = new Regex(pattern);
        Console.WriteLine(Regex.Replace(text, pattern, replacement));
    }
}
