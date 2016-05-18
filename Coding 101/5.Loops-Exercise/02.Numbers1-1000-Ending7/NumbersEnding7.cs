using System;

class NumbersEnding7
{
    static void Main()
    {
        int lastNumber = 1000;

        for (int sequence = 1; sequence <= lastNumber; sequence++)
        {
            if (sequence % 10 == 7)
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
