using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a score: ");
        double score = double.Parse(Console.ReadLine());
        double bonus = 0;
        double bonusExtra = 0;
        if (score <= 100)
        {
            bonus = 5;
        }
        else if (score > 100 && score <= 1000)
        {
            bonus = 0.2 * score;
        }
        else if (score > 1000)
        {
            bonus = 0.1 * score;
        }
        if (score % 2 == 0)
        {
            bonusExtra = 1;
        }
        else if (score % 5 == 0)
        {
            bonusExtra = 2;
        }
        Console.WriteLine("Bonus score: {0:f2}", Math.Round(bonus + bonusExtra, 2));
        Console.WriteLine("Total score: {0:f2}", Math.Round(score + bonus + bonusExtra, 2));
    }
}
