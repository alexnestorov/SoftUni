using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        char[] symbolCar = new char[10] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int[] symbolValues = new int[10] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        int magicCount = 0;
        for (int d1 = 0; d1 < 10; d1++)
        {
            for (int d2 = 0; d2 < 10; d2++)
            {
                for (int d3 = 0; d3 < 10; d3++)
                {
                    for (int d4 = 0; d4 < 10; d4++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                bool magicCombination = FoundMagicCombination(d1, d2, d3, d4);
                                int calculateMagicWeight = symbolValues[0] + symbolValues[2] + d1 + d2 + d3 + d4
                                    + symbolValues[x] + symbolValues[y];
                                if (magicCombination && (calculateMagicWeight == magicWeight))
                                {
                                    //Console.Write("CA{0}{1}{2}{3}{4}{5}, ", d1, d2, d3, d4, symbolCar[x], symbolCar[y]);
                                    magicCount++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(magicCount);
    }

    private static bool FoundMagicCombination(int d1, int d2, int d3, int d4)
    {
       
        bool allDigitsAreEqual = (d1 == d2) && (d1 == d3) && (d1 == d4);
        bool lastThreeDigitsAreEqual = (d2 == d3) && (d2 == d4);
        bool firstThreeDigitsAreEqual = (d1 == d2) && (d1 == d3);
        bool firstThirdDigitsAreEqual = (d1 == d3) && (d2 == d4);
        bool firstLastDigitsAreEqual = (d1 == d4) && (d2 == d3);
        bool firstSecondDigitsAreEqual = (d1 == d2) && (d3 == d4);
        if (allDigitsAreEqual)
        {
            return true;
        }
        if (lastThreeDigitsAreEqual)
        {
            return true;

        }
        if (firstThreeDigitsAreEqual)
        {
            return true;
        }
        if (firstThirdDigitsAreEqual)
        {
            return true;
        }
        if (firstLastDigitsAreEqual)
        {
            return true;

        }
        if (firstSecondDigitsAreEqual)
        {
            return true;
        }
        return false;
    }
}