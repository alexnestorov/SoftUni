using System;
using System.Numerics;

class PetarGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        BigInteger sumNumbers = 0;
        string result = "";

        for (ulong count = startNumber; count < endNumber; count++)
        {
            if (count % 5 == 0)
            {
                sumNumbers += count;
            }
            else
            {
                sumNumbers += count % 5;
            }
        }
        result = sumNumbers.ToString();
        string digitReplace = "";

        if (sumNumbers % 2 == 0)
        {
            digitReplace = result[0].ToString();
        }
        else if (sumNumbers % 2 != 0)
        {
            digitReplace = result[result.Length - 1].ToString();
        }
        result = result.Replace(digitReplace, replacement);
        Console.WriteLine(result);
    }
}
