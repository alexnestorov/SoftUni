using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = (3 * n / 2 - 1);
        PrintCarsTopPart(n);
        PrintCarsMiddlePart(n, width);
        PrintCarsBottomPart(n);
    }

    static void PrintCarsMiddlePart(int n, int width)
    {
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', width - 2));
        }
        Console.WriteLine("{0}", new string('*', width));
    }

    static void PrintCarsBottomPart(int n)
    {
        for (int i = 0; i <= n / 2 - 2; i++)
        {
            if (i == n / 2 - 2)
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}"
               , new string('.', n / 2)
               , new string('*', n / 2 - 1)
               , new string('.', n - 2));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}"
                    , new string('.', n / 2)
                    , new string('.', n / 2 - 1)
                    , new string('.', n - 2));
            }
        }
    }

    static void PrintCarsTopPart(int n)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}*{1}*{0}"
                                , new string('.', n - i)
                                , new string('*', n - 2 + 2 * i));
            }
            else if (i == n / 2)
            {
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('*', n - i)
                    , new string('.', n - 2 + 2 * i));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('.', n - i)
                    , new string('.', n - 2 + 2 * i));
            }
        }
    }
}