using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchFullName
{
    static void Main()
    {
        string text = Console.ReadLine();
        //string[] textToMatch = { "ivan ivanov", "Ivan ivanov", "ivan Ivanov", "IVan Ivanov", "Ivan IvAnov", "Ivan Ivanov" };
        // Pattern for searching a full name with first capital letter.
        string pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
        Regex rgx = new Regex(pattern);
        while (text != "end")
        {
            bool containsValidFullName = rgx.IsMatch(text);
            if (containsValidFullName)
            {
                Console.WriteLine(text);
            }
            text = Console.ReadLine();
        }
        

    }
}

