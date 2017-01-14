using System;

class PlaidTowel
{
    static void Main()
    {
        int numberPlaid = int.Parse(Console.ReadLine());
        char backgroundSymbol = char.Parse(Console.ReadLine());
        char rhombysSymbol = char.Parse(Console.ReadLine());
        Console.Write("{0}",new string(backgroundSymbol, numberPlaid));
        Console.Write("{0}",new string(rhombysSymbol, 1));
        Console.Write("{0}", new string(backgroundSymbol, 2 * numberPlaid - 1));
        Console.Write("{0}", new string(rhombysSymbol, 1));
        Console.Write("{0}", new string(backgroundSymbol, numberPlaid));
        Console.WriteLine();

        for (int count = 1; count <= numberPlaid; count++)
        {
            Console.Write("{0}", new string(backgroundSymbol, numberPlaid - count));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}", new string(backgroundSymbol, 2 * count - 1));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));
                Console.Write("{0}", new string(rhombysSymbol, 1));
            }

            Console.Write("{0}", new string(backgroundSymbol, 2 * count - 1));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}", new string(backgroundSymbol, numberPlaid - count));
            Console.WriteLine();
        }
        for (int count = 1; count <= numberPlaid; count++)
        {
            Console.Write("{0}", new string(backgroundSymbol, count));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));
                Console.Write("{0}", new string(rhombysSymbol, 1));
            }
            Console.Write("{0}", new string(backgroundSymbol, 2 * (count - 1) + 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(rhombysSymbol, 1));
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));

            }
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}", new string(backgroundSymbol, count));
            Console.WriteLine();
        }
        for (int count = 1; count <= numberPlaid; count++)
        {
            Console.Write("{0}", new string(backgroundSymbol, numberPlaid - count));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}", new string(backgroundSymbol, 2 * count - 1));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));
                Console.Write("{0}", new string(rhombysSymbol, 1));
            }

            Console.Write("{0}", new string(backgroundSymbol, 2 * count - 1));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}", new string(backgroundSymbol, numberPlaid - count));
            Console.WriteLine();
        }
        for (int count = 1; count <= numberPlaid; count++)
        {
            Console.Write("{0}", new string(backgroundSymbol, count));
            Console.Write("{0}", new string(rhombysSymbol, 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));
                Console.Write("{0}", new string(rhombysSymbol, 1));
            }
            Console.Write("{0}", new string(backgroundSymbol, 2 * (count - 1) + 1));
            if (count == numberPlaid)
            {
                Console.Write("{0}", new string(backgroundSymbol, 0));
                Console.Write("{0}", new string(rhombysSymbol, 0));
            }
            else
            {
                Console.Write("{0}", new string(rhombysSymbol, 1));
                Console.Write("{0}", new string(backgroundSymbol, 2 * (numberPlaid - count) - 1));

            }
            Console.Write("{0}", new string(rhombysSymbol, 1));
            Console.Write("{0}",new string(backgroundSymbol, count));
            Console.WriteLine();
        }
    }
}