using System;

class SquareFrame
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string minus = "- ";
        Console.Write("+ ");
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write("{0}", minus);
        }
        Console.Write("+");
        Console.WriteLine();
        for (int count = 0; count < number - 2; count++)
        {
            Console.Write("| ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("{0}", minus);
            }
            Console.Write("|");
            Console.WriteLine();
        }
        Console.Write("+ ");
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write("{0}", minus);
        }
        Console.Write("+");
        Console.WriteLine();
    }
}
