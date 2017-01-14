using System;

class SummerTime
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string(' ', oddNumber / 2), new string('*', oddNumber + 1));
        for (int count = 0; count <= (oddNumber / 2); count++)
        {
            Console.WriteLine("{0}{1}{2}{1}"
                , new string(' ', (oddNumber / 2))
                , new string('*', 1)
                , new string(' ', oddNumber - 1));
        }
        for (int count = 0; count < (oddNumber / 2) - 1; count++)
        {
            Console.WriteLine("{0}{1}{2}{1}"
                , new string(' ', (oddNumber / 2) - count - 1)
                , new string('*', 1)
                , new string(' ', (oddNumber + 1) + 2 * count));
        }
        for (int count = 0; count < 2 * oddNumber; count++)
        {
            if (count < oddNumber)
            {
                Console.WriteLine("{0}{1}{0}"
                , new string('*', 1)
                , new string('.', (2 * oddNumber) - 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}"
                , new string('*', 1)
                , new string('@', (2 * oddNumber) - 2));
            }
        }
        Console.WriteLine("{0}", new string('*', oddNumber * 2));
    }
}
