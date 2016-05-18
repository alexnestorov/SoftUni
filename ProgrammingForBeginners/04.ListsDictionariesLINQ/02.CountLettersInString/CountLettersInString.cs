using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountLettersInString
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        int[] count = new int[word.Max() + 1];

        foreach (var letter in word)
        {
            count[letter]++;
        }
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
            {
                char letter = (char)i;
                int occ = count[i];
                Console.WriteLine("{0} -> {1}", letter, occ);
            }
        }
    }
}
