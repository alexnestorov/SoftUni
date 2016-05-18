using System;

class House
{
    static void Main()
    {
        int houseNumber = int.Parse(Console.ReadLine());

        if (houseNumber % 2 == 0)
        {
            for (int i = 1; i <= houseNumber / 2; i++)
            {
                Console.Write(new string('-', houseNumber / 2 - i));
                Console.Write(new string('*', 2 * i));
                Console.Write(new string('-', houseNumber / 2 - i));
                Console.WriteLine();
            }
            for (int i = 1; i <= houseNumber / 2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', houseNumber - 2));
                Console.Write(new string('|', 1));
                Console.WriteLine();
            }
        }
        else if (houseNumber % 2 != 0)
        {
            for (int i = 1; i <= (houseNumber / 2) + 1; i++)
            {
                Console.Write(new string('-', houseNumber / 2 - (i - 1)));
                Console.Write(new string('*', 2 * i - 1));
                Console.Write(new string('-', houseNumber / 2 - (i - 1)));
                Console.WriteLine();
            }
            for (int i = 1; i <= houseNumber / 2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', houseNumber - 2));
                Console.Write(new string('|', 1));
                Console.WriteLine();
            }

        }
    }
}
