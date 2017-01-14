using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTopPartHeadphones(n);
        PrintFirstPatHeadphones(n);
        PrintSecondPartHeadphones(n);
    }

    static void PrintSecondPartHeadphones(int n)
    {
        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}"
                , new string('-', n / 2 - i)
                , new string('*', 2 * i + 1),
                new string('-', n - 2 * i));
        }
    }

    static void PrintFirstPatHeadphones(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}"
                , new string('-', n / 2 - i)
                , new string('*', 2 * i + 1),
                new string('-', n - 2 * i));
        }
    }

    static void PrintTopPartHeadphones(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}*{1}*{0}"
                , new string('-', n / 2)
                , new string('*', n));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}"
                , new string('-', n / 2)
                , new string('-', n));
            }

        }
    }
}
