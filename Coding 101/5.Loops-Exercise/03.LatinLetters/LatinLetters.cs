using System;

class LatinLetters
{
    static void Main()
    {
        //char[] latinLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
        //    't','u','v','w','x','y','z' };
        //char symbol = 'a';

        for (char letter = 'а'; letter <= 'я'; letter++)
        {
            if (letter != 'э' && letter != 'ы')
            {
                Console.WriteLine("{0}", letter);
            }
        }
    }
}
