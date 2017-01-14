using System;

class ImpressTheGirlfriend
{
    static void Main()
    {
            // Input data
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euros = double.Parse(Console.ReadLine());
        double levaB = double.Parse(Console.ReadLine());
        double levaM = double.Parse(Console.ReadLine());

            // Main logic calculate most expensive game
        double gameRubles = rubles * 0.035;
        double gameDollars = dollars * 1.5;
        double gameEuros = euros * 1.95;
        double gameLevaB = levaB / 2;
        double gameLevaM = levaM * 1;
        double maxExpensiveGame = double.MinValue;

        if (gameRubles > maxExpensiveGame)
        {
            maxExpensiveGame = gameRubles;
        }
        if (gameDollars > maxExpensiveGame)
        {
            maxExpensiveGame = gameDollars;
        }
        if (gameEuros > maxExpensiveGame)
        {
            maxExpensiveGame = gameEuros;
        }
        if (gameLevaB > maxExpensiveGame)
        {
            maxExpensiveGame = gameLevaB;
        }
        if (gameLevaM > maxExpensiveGame)
        {
            maxExpensiveGame = gameLevaM;
        }

        Console.WriteLine("{0:F2}", Math.Ceiling(maxExpensiveGame));
    }
}
