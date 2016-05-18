using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintStringLetters
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();

        for (int i = 0; i < word.Length; i++)
        {
            char symbol = word[i];
            Console.WriteLine("str [{0}] -> '{1}'",i, symbol);
        }
    }
}
