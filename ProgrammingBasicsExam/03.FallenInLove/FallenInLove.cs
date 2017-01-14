using System;

class FallenInLove
{
    static void Main()
    {
        int numberFlower = int.Parse(Console.ReadLine());

        for (int count = 0; count < numberFlower; count++)
        {
            Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}"
                , new string('#', 1)
                , new string('~', count)
                , new string('.', 2 * (numberFlower - count))
                , new string('.', (2 * count)));
        }
        for (int count = 0; count <= numberFlower; count++)
        {
            Console.WriteLine("{2}{0}{1}{0}{3}{0}{1}{0}{2}"
                , new string('#', 1)
                , new string('~', numberFlower - count)
                , new string('.', 2 * count + 1)
                , new string('.', 2 * (numberFlower - count)));
        }
        for (int count = 0; count < numberFlower; count++)
        {
            Console.WriteLine("{1}{0}{1}"
                , new string('#', 2)
                , new string('.', 2 * numberFlower + 2));
        }
    }
}
