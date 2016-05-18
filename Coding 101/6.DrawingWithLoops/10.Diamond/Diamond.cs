using System;

class Diamond
{
    static void Main()
    {
        int diamond = int.Parse(Console.ReadLine());
        bool evenNumber = diamond % 2 == 0;
        bool oddNumber = diamond % 2 != 0;

        if (evenNumber)
        {
            for (int count = 1; count <= diamond / 2; count++)
            {
                Console.Write(new string('-', (diamond / 2) - count));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', 2 * count - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', (diamond / 2) - count));
                Console.WriteLine();
            }
            for (int count = 1; count < diamond / 2; count++)
            {
                Console.Write(new string('-', count));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', diamond - 2 * count - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', count));
                Console.WriteLine();
            }
        }
        else if (oddNumber)
        {
            for (int count = 0; count <= diamond / 2; count++)
            {
                Console.Write(new string('-', (diamond / 2) - count));
                Console.Write(new string('*', 1));
                if (count == 0)
                {
                    Console.Write(new string('*', 0));
                }
                else
                {
                    Console.Write(new string('-', 2 * count - 1));
                    Console.Write(new string('*', 1));
                }
                Console.Write(new string('-', (diamond / 2) - count));
                Console.WriteLine();
            }
            for (int count = 1; count <= diamond / 2; count++)
            {
                Console.Write(new string('-', count));
                Console.Write(new string('*', 1));
                if (count == diamond / 2)
                {
                    Console.Write(new string('*', 0));
                }
                else
                {
                    Console.Write(new string('-', diamond - 2 * count - 2));
                    Console.Write(new string('*', 1));
                }
                Console.Write(new string('-', count));
                Console.WriteLine();
            }
        }
    }
}
