using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOccInStrings
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine();
        int count = 0;
        int pos = 0;
        while (true)
        {
            pos = str.IndexOf(pattern, pos);
            if (pos == -1)
            {
                break;
            }
            count++;
            pos++;
        }
        Console.WriteLine(count);
    }
}
