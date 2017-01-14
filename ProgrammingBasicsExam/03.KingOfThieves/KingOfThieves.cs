using System;

class KingOfThieves
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());
        char thievesSymbol = char.Parse(Console.ReadLine());

        // First part of the card
        for (int count = 0; count <= oddNumber / 2; count++)
        {
            Console.Write(new string('-', (oddNumber / 2) - count));
            Console.Write("{0}", new string(thievesSymbol, (2 * count) + 1));
            Console.Write(new string('-', (oddNumber / 2) - count));
            Console.WriteLine();
        }
        // Second part of the card
        for (int count = 1; count <= oddNumber / 2; count++)
        {
            Console.Write(new string('-', count));
            Console.Write("{0}", new string(thievesSymbol, (oddNumber - (2 * count))));
            Console.Write(new string('-', count));
            Console.WriteLine();
        }
    }
}
