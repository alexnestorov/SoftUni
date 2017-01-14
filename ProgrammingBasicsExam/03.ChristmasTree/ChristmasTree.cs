using System;

class ChristmasTree
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());

        for (int count = 0; count <= oddNumber / 2; count++)
        {
            Console.Write(new string('\'', oddNumber - count));
            Console.Write(new string('^', 2 * count + 1));
            Console.Write(new string('\'', oddNumber - count));
            Console.WriteLine();
        }
        for (int count = 0; count <= oddNumber / 2; count++)
        {
            Console.Write(new string('\'', oddNumber - count - 1));
            Console.Write(new string('^', 2 * count + 3));
            Console.Write(new string('\'', oddNumber - count - 1));
            Console.WriteLine();
        }
        for (int scape = 0; scape <= oddNumber / 2; scape++)
        {
            Console.Write(new string('\'', oddNumber - 1));
            Console.Write(new string('|', 1));
            Console.Write(new string(' ', 1));
            Console.Write(new string('|', 1));
            Console.Write(new string('\'', oddNumber - 1));
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', 2 * oddNumber + 1));
    }
}
