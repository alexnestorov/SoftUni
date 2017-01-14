using System;

class CurrencyCheck
{
    static void Main()
    {
        uint rubles = uint.Parse(Console.ReadLine());
        uint dollars = uint.Parse(Console.ReadLine());
        uint euros = uint.Parse(Console.ReadLine());
        uint levaB = uint.Parse(Console.ReadLine());
        uint levaM = uint.Parse(Console.ReadLine());

        decimal gameRubblesInLeva = (rubles / 100m) * 3.5m;
        decimal gameDollarsInLeva = dollars * 1.5m;
        decimal gameEurosInLeva = euros * 1.95m;
        decimal gameLevaB = levaB / 2.0m;
        decimal gameLevaM = levaM;
        decimal[] gameAmountArray = { gameRubblesInLeva, gameDollarsInLeva, gameEurosInLeva, gameLevaB, gameLevaM };
        decimal cheapestGame = decimal.MaxValue;
        for (uint i = 0; i < gameAmountArray.Length; i++)
        {
            if (gameAmountArray[i] < cheapestGame)
            {
                cheapestGame = gameAmountArray[i];
            }
        }
        Console.WriteLine("{0:F2}", cheapestGame);
    }
}
