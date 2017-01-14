using System;

class IlluminatiLock
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());
        int numberSign = oddNumber;
        int dot = oddNumber;

        Console.Write(new string('.', numberSign));
        Console.Write(new string('#', dot));
        Console.Write(new string('.', numberSign));
        Console.WriteLine();

        for (int i = 1; i <= oddNumber / 2; i++)
        {
            Console.Write(new string('.', dot - 2*i));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', 2*i - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', dot - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 2 * i - 2));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', dot - 2*i));
            Console.WriteLine();
        }
        for (int i = 1; i <= oddNumber / 2; i++)
        {
            Console.Write(new string('.', 2 * i - 1));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', oddNumber - 2 * i - 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', dot - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', oddNumber - 2 * i - 1));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', 2 * i - 1));
            Console.WriteLine();
        }

        Console.Write(new string('.', numberSign));
        Console.Write(new string('#', dot));
        Console.Write(new string('.', numberSign));
        Console.WriteLine();
    }
}
