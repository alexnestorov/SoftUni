using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DressPattern
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 12 * n + 2;
        int underScore = 4 * n;
        PrintFirstPart(width, underScore);
        PrintBelt(n, width);
        PrintBelt2(n, width);
        LastPart(n, width);
    }

    private static void LastPart(int n, int width)
    {
        for (int i = 3 * n; i > 0; i--)
        {
            Console.WriteLine("{0}.{1}.{0}", new string('_', i), new string('*', width - 2 * i - 2));
        }
        Console.WriteLine("{0}", new string('.', width));
    }

    private static void PrintBelt2(int n, int width)
    {
        Console.WriteLine("{0}{1}{0}", new string('.', 3 * n), new string('*', width - 6 * n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('_', 3 * n), new string('o', width - 6 * n));
        }
    }

    private static void PrintBelt(int n, int width)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(".{0}.", new string('*', width - 2));
        }
    }

    private static void PrintFirstPart(int width, int underScore)
    {
        for (int i = 0; i <= underScore / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}.{0}.{0}", new string('_', underScore - 2 * i));
            }
            else
            {
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}"
                    , new string('_', underScore - 2 * i)
                    , new string('*', (width - 3 * (underScore - 2 * i) - 4) / 2));
            }
        }
    }
}
