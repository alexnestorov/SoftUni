using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DrawFort
{
    static void Main(string[] args)
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        int bottom = 2 * n - (2 *(n / 2) + 4); 
        
        // First row
        Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}"
            , new string('/', 1)
            , new string('^', n / 2)
            , new string('\\', 1)
            , new string('_',bottom));
        
        //Middle part
        for (int i = 0; i < n - 2; i++)
        {
            if (i == n -3)
            {
                Console.WriteLine("|{0}{1}{0}|"
                    , new string(' ', (n / 2) + 1)
                    , new string('_', bottom));
            }
            else
            {
                Console.WriteLine("|{0}|", new string(' ', (2 * n) - 2));
            }
            
        }

        // Last row
        Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}"
            , new string('\\', 1)
            , new string('_', n / 2)
            , new string('/', 1)
            ,new string(' ', bottom));
    }
}
