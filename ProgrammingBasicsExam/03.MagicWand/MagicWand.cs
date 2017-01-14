using System;

class MagicWand
{
    static void Main()
    {
        // Input number between 5 and 39
        int oddNumber = int.Parse(Console.ReadLine());

        int row = 3 * oddNumber + 2;
        Console.WriteLine("{0}{1}{0}"
             , new string('.', (row / 2))
             , new string('*', 1));

        // Loop for first part of the figure
        for (int i = 1; i <= (oddNumber / 2) + 1; i++)
        {
                Console.WriteLine("{0}{1}{2}{1}{0}"
               , new string('.', (row / 2) - i)
               , new string('*', 1)
               , new string('.', 2 * i - 1));
        }
        Console.WriteLine("{0}{1}{0}"
              , new string('*', oddNumber)
              , new string('.', row - 2 * oddNumber));
        
        //Loop for middle part of the figure
        for (int i = 0; i < oddNumber / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}"
               , new string('.', i + 1)
               , new string('*', 1)
               , new string('.', row - 2*(i + 1) - 2));
        }
        for (int i = 0; i < oddNumber / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}"
               , new string('.', (oddNumber / 2) - i - 1)
               , new string('.', oddNumber / 2)
               , new string('.', i)
               , new string('.', oddNumber));
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}"
            , new string('*', (oddNumber / 2) + 1)
            , new string('.', oddNumber / 2)
            , new string('.', oddNumber));
        
        // Loop for the last part of the figure
        for (int i = 0; i <= oddNumber; i++)
        {
            if (i == oddNumber)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}"
                 , new string('.', oddNumber)
                 , new string('*', 1)
                 , new string('*', oddNumber));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{1}{0}"
             , new string('.', oddNumber)
             , new string('*', 1));
            }
        }
    }
}
