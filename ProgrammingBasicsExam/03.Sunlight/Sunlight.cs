using System;

class Sunlight
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());

            // First line
        Console.WriteLine("{0}*{0}", new string('.', ((3 * oddNumber) - 1) / 2));
            // First part
        for (int count = 0; count < oddNumber - 1; count++)
        {
            Console.Write(new string('.', count + 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', (3 * oddNumber / 2) - count - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', (3 * oddNumber / 2) - count - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', count + 1));
            Console.WriteLine();
        }

            // Middle part
        for (int count = 0; count < oddNumber / 2; count++)
        {
            Console.Write(new string('.', oddNumber));
            Console.Write(new string('*', oddNumber));
            Console.Write(new string('.', oddNumber));
            Console.WriteLine();
        }
        Console.WriteLine("{0}", new string('*', 3 * oddNumber));
        for (int count = 0; count < oddNumber / 2; count++)
        {
            Console.Write(new string('.', oddNumber));
            Console.Write(new string('*', oddNumber));
            Console.Write(new string('.', oddNumber));
            Console.WriteLine();
        }
            // Second part
        for (int count = 1; count < oddNumber; count++)
        {
            Console.Write(new string('.', oddNumber - count));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', (3 * oddNumber / 2) - (oddNumber - count) - 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', (3 * oddNumber / 2) - (oddNumber - count) - 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', oddNumber - count));
            Console.WriteLine();
        }
            // Last line
        Console.WriteLine("{0}*{0}", new string('.', ((3 * oddNumber) - 1) / 2));

    }
}
