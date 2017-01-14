using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintFirstPartFlag(n);
        PrintSecondPartFlag(n);
        PrintBottomPart(n);
    }

    static void PrintFirstPartFlag(int n)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}"
                , new string('.', n - 2 * i - 1)
                , new string('*', 2 * i + 1)
                , new string('.', n));
        }
    }

    static void PrintSecondPartFlag(int n)
    {
        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{2}"
                , new string('.', n - 2 * i - 1)
                , new string('*', 2 * i + 1)
                , new string('.', n));
        }
    }

    static void PrintBottomPart(int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}"
                , new string('.', i)
                , new string('*', 2 * n - 2 * i));
        }
    }
}
