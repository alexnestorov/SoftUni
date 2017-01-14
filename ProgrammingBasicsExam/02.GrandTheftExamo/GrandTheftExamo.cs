using System;

class GrandTheftExamo
{
    static void Main()
    {
        // Input variables using long because of the escape attempts
        int escapeAttempts = int.Parse(Console.ReadLine());
        long thieves = 0;
        long beersAmount = 0;
        long slapped = 0;
        long escaped = 0;
        long totalBeers = 0;

        // Main logic
        for (int attempts = 0; attempts < escapeAttempts; attempts++)
        {
            thieves = int.Parse(Console.ReadLine());
            beersAmount = int.Parse(Console.ReadLine());
            if (thieves > 5)
            {
                slapped += 5;
                escaped += thieves - 5;
            }
            else
            {
                slapped += thieves;
            }
            totalBeers += beersAmount;
        }

        // Output
        long sixpacks = totalBeers / 6;
        long bottles = totalBeers % 6;
        Console.WriteLine("{0} thieves slapped.\n{1} thieves escaped.\n{2} packs, {3} bottles."
            , slapped
            , escaped
            , sixpacks
            , bottles);
    }
}
