using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ValidUsernames
{
    static void Main()
    {
        char[] delimiter = new[] { ' ', '(', ')', '\\', '/' };
        string[] usernames = Console.ReadLine()
                                    .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

        // Pattern for valid username. Start with a letter, consist letters, digits or '_'.
        // Length is between 3 and 25 characters.
        string pattern = @"^[A-za-z]\w{2,24}$";
        Regex rgx = new Regex(pattern);
        List<string> validUsernames = new List<string>();

        // Extract valid usernames.
        foreach (string user in usernames)
        {
            bool containsValidUsername = rgx.IsMatch(user);
            if (containsValidUsername)
            {
                validUsernames.Add(user);
            }

        }

        // Get couple of consecutive validusername according to their best length.
        int bestLength = 0;
        int p1 = -1;
        int p2 = -1;
        for (int i = 1; i < validUsernames.Count; i++)
        {
            int currentLength = validUsernames[i].Length + validUsernames[i - 1].Length;
            if (currentLength > bestLength)
            {
                bestLength = currentLength;
                p1 = i - 1;
                p2 = i;
            }
        }
        Console.WriteLine(validUsernames[p1]);
        Console.WriteLine(validUsernames[p2]);
    }
}
