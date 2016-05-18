using System;

class Diamond
{
    static void Main()
    {
        int diamond = int.Parse(Console.ReadLine());
        for (int i = 0; i < diamond; i++)
        {
            int spaces = diamond - 1 - i;
            Console.Write(new string(' ', spaces));
            Console.Write("*");
            for (int j = 0; j < i; j++)
            {
                Console.Write("-*");
            }
            Console.Write(new string(' ', spaces));
            Console.WriteLine();
        }
        for (int i = diamond - 2; i >= 0 ; i--)
        {
            int spaces = diamond - 1 - i;
            Console.Write(new string(' ', spaces));
            Console.Write("*");
            for (int j = 0; j < i; j++)
            {
                Console.Write("-*");
            }
            Console.Write(new string(' ', spaces));
            Console.WriteLine();
        }
    }
}

