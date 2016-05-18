using System;

class Strawberry
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n + 3;

        PrintTopPart(n);

        PrintMiddlePart(n, width);

        PrintBottomPart(n, width);
    }

    static void PrintBottomPart(int n, int width)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', i + 1)
                                           , new string('.', width - 2 * i - 4));
        }
    }

    static void PrintMiddlePart(int n, int width)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', n - 2 * i)
                                           , new string('.', 4 * i + 1));
        }
        Console.WriteLine("#{0}#", new string('.', width - 2));
    }

    static void PrintTopPart(int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', 2 * i)
                                                , new string('-', n - 2 * i));
        }
    }
}

