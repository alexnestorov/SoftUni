using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchPhoneNumber
{
    static void Main()
    {
        string text = Console.ReadLine();
        //string[] textToMatch = { "+359-2-222-2222", "+359/2/222/2222", "+359-2 222 2222",
        //                         "+359 2-222-2222", "+359-2-222-222", "+359-2-222-22222", "+359 3 444 5555"};
        // Pattern for searching a phone number in format +359-d-ddd-dddd +359 d ddd dddd.
        string pattern = @"^\+[359]{3}(\-| )\d{1}\1\d{3}\1\d{4}$";
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
