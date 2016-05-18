using System;

class TriplesOfLetters
{
    static void Main()
    {
        int numberLetters = int.Parse(Console.ReadLine());

        for (char first = 'a'; first < 'a' + numberLetters; first++)
        {
            for (char second = 'a'; second < 'a' + numberLetters; second++)
            {
                for (char third = 'a'; third < 'a' + numberLetters; third++)
                {
                    Console.WriteLine("{0}{1}{2}", first, second, third);
                }
            }
        }
    }
}
