using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());


        while (true)
        {
            string position = Console.ReadLine();
            if (position.Contains("quit"))
            {
                break;
            }
            string command = Console.ReadLine();
            if (command.Contains("quit"))
            {
                break;
            }

            int bitPosition = int.Parse(position);
            int mask = 0;
            for (int i = 0; i < bitPosition; i++)
            {
                mask <<= 1;
                mask = mask | 1;
            }
            long rightBits = number & mask;
            if (command.Contains("skip"))
            {
                continue;
            }
            else if (command.Contains("flip"))
            {
                number = FlipBit(number, bitPosition);
            }
            else if (command.Contains("insert"))
            {
                number = InsertBitOneAtPosition(number, bitPosition);
            }
            else if (command.Contains("remove"))
            {
                number = RemoveBitAtPosition(number, bitPosition);
            }
        }
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }

    static long RemoveBitAtPosition(long number, int bitPosition)
    {
        int mask = 0;
        for (int i = 0; i < bitPosition; i++)
        {
            mask <<= 1;
            mask = mask | 1;
        }
        long rightBits = number & mask; // Get right bits from bitposition.
        number >>= bitPosition + 1; // Turns right to clear the right bits.
        number <<= bitPosition; // Turns left to clear the bit position.
        number |= rightBits; // Return back the right bits.
        return number;
    }

    static long InsertBitOneAtPosition(long number, int bitPosition)
    {
        int mask = 0;
        for (int i = 0; i < bitPosition; i++)
        {
            mask <<= 1;
            mask = mask | 1;
        }
        long rightBits = number & mask; // Get right bits from bitposition.
        number >>= bitPosition; // Turns right to clear the right bits.
        number <<= bitPosition + 1; // Turns left to free the bit position.
        number |= (long)1 << bitPosition; // Set value 1 to bitposition.
        number |= rightBits; // Return back the right bits.
        return number;
    }

    static long FlipBit(long number, int bitPosition)
    {
        int mask = 1 << bitPosition;
        long result = (number & mask);
        number = (number ^ mask);
        return number;
    }
}
