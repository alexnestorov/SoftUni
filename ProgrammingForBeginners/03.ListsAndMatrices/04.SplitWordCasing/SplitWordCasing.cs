using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SplitWordCasing
{
    static void Main()
    {
        // , ; : . ! ( ) " ' / \ [ ]
        char[] delimiter = { ',', ';', ':', '.', '!', '(', ')', ' ', '\"', '\'', '/', '\\', '[', ']' };
        List<string> words = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixCase = new List<string>();
        foreach (var word in words)
        {
            int lowerCount = 0;
            int upperCount = 0;
            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    lowerCount++;
                }
                else if (char.IsUpper(letter))
                {
                    upperCount++;
                }
            }
            if (lowerCount == word.Length)
            {
                lowerCase.Add(word);
            }
            else if (upperCount == word.Length)
            {
                upperCase.Add(word);
            }
            else
            {
                mixCase.Add(word);
            }
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

    }
}
