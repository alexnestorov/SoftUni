using System;

class StrippedTowel
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int width = number;
        double height = Math.Truncate(number * 1.5);
        char diagonal = '#';
        char dot = '.';
        for (int i = 0; i < height; i++)
        {
            for (int count = 0; count < width; count++)
            {
                if ((count + i) % 3 == 0)
                {
                    Console.Write(diagonal);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }

    }
}
