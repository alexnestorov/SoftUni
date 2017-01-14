using System;

class AceOfDiamonds
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());

        Console.Write(new string('*', oddNumber));
        Console.WriteLine();
        for (int count = 1; count < oddNumber / 2; count++)
        {
            Console.Write(new string('*', 1));
            Console.Write(new string('-', oddNumber / 2 - count));
            Console.Write(new string('@', 2 * count - 1 ));
            Console.Write(new string('-', oddNumber / 2 - count));
            Console.Write(new string('*', 1));
            Console.WriteLine();
        }
        for (int reverseCount = 1; reverseCount < (oddNumber / 2) + 1; reverseCount++)
        {
            Console.Write(new string('*', 1));
            Console.Write(new string('-', reverseCount - 1));
            Console.Write(new string('@', oddNumber - 2 * reverseCount));
            Console.Write(new string('-', reverseCount - 1));
            Console.Write(new string('*', 1));
            Console.WriteLine();
        }
        Console.Write(new string('*', oddNumber));
    }
}
