using System;

class RectangleWithStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // First row
        Console.WriteLine(new string('%', 2 * n));
        // First part includind row with two **
        for (int i = 0; i <= (n - 1) / 2; i++)
        {
            Console.Write("%");
            if (i == (n - 1) / 2)
            {
                Console.Write(new string(' ', n - 2));
                Console.Write("**");
                Console.Write(new string(' ', n - 2));
            }
            else
            {
                Console.Write(new string(' ', 2 * n - 2));
            }
            Console.Write("%");
            Console.WriteLine();
        }
        // Second part
        for (int i = 0; i < (n - 1)/ 2; i++)
        {
            Console.Write("%");
            Console.Write(new string(' ', 2 * n - 2));
            Console.Write("%");
            Console.WriteLine();
        }
        // Last row
        Console.WriteLine(new string('%', 2 * n));
    }
}
