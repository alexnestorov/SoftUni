using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i <= n; i++)
        {
            string asterisks = new string('*', i);
            Console.WriteLine(asterisks);
            for (int j = 3; j <= n; j++)
            {
                string asteriks = new string('*', 1);
                string spaces = new string(' ', n - 2);
                Console.Write(asteriks);
                Console.Write(spaces);
                Console.Write(asteriks);
                Console.WriteLine();
            }
            Console.WriteLine(asterisks);
        }
    }
}
