using System;

class FourFactors
{
    static void Main()
    {
            // Input variables. Using double to divide numbers
        double goals = double.Parse(Console.ReadLine());
        double goalsAttempts = double.Parse(Console.ReadLine());
        double goalsThreePodoubles = double.Parse(Console.ReadLine());
        double turnovers = double.Parse(Console.ReadLine());
        double reb = double.Parse(Console.ReadLine());
        double oppReb = double.Parse(Console.ReadLine());
        double freethrows = double.Parse(Console.ReadLine());
        double freeThrowsAttempts = double.Parse(Console.ReadLine());
        double sum = reb + oppReb;

            // Formulas to calculate percent of each statement
        double percentEFG = (goals + 0.5 * goalsThreePodoubles) / goalsAttempts;
        double percentTurnover = turnovers / (goalsAttempts + 0.44 * freeThrowsAttempts + turnovers);
        double percentOffRebound = reb / sum;
        double percentFreethrows = freethrows / goalsAttempts;

            // Output data. Using format F3 to print number up to 3 digits after the decimal point
        Console.WriteLine("eFG% {0:F3}", percentEFG);
        Console.WriteLine("TOV% {0:F3}", percentTurnover);
        Console.WriteLine("ORB% {0:F3}", percentOffRebound);
        Console.WriteLine("FT% {0:F3}", percentFreethrows);
    }
}
