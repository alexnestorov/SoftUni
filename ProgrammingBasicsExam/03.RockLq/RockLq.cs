using System;

class RockLq
{
    static void Main()
    {
        int odd = int.Parse(Console.ReadLine());
        int width = 3 * odd;

        UpperPartDress(odd, width);

        MiddleRow(odd);

        SleevePart(odd);

        BottomPartDress(odd);

        LastDressRow(odd);
    }

    static void UpperPartDress(int odd, int width)
    {
        for (int i = 0; i <= odd / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}"
                , new string('.', odd)
                , new string('*', odd));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('.', odd - 2 * i)
                    , new string('.', width - 2 * (odd - 2 * i) - 2));
            }
        }
    }

    static void MiddleRow(int odd)
    {
        Console.WriteLine("*{1}*{0}*{1}*"
                    , new string('.', odd)
                    , new string('.', odd - 2));
    }

    static void SleevePart(int odd)
    {
        for (int i = 1; i < odd / 2; i++)
        {
            Console.WriteLine("*{1}*{2}*{0}*{2}*{1}*"
                , new string('.', odd)
                , new string('.', odd - 2 - 2 * i)
                , new string('.', 2 * i - 1));
        }
    }

    static void BottomPartDress(int odd)
    {
        for (int i = 0; i < odd - 1; i++)
        {
            Console.WriteLine("{1}*{0}*{1}"
           , new string('.', odd + 2 * i)
           , new string('.', odd - 1 - i));
        }
    }

    static void LastDressRow(int odd)
    {
        Console.WriteLine(new string('*', 3 * odd));
    }
}
