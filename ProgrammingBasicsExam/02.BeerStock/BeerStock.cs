using System;

class BeerStock
{
    static void Main()
    {
            // Input data
        int amountReservedBeers = int.Parse(Console.ReadLine());
        string shipment = "";
        string[] numberBeers = shipment.Split();
        long amountOfBeers = 0;
        long amountOfSixpacksBeers = 0;
        long amountOfCasesBeers = 0;

            // Convert string to integer number
        while (shipment != "exam over")
        {
            shipment = Console.ReadLine().ToLower();
            numberBeers = shipment.Split();
            if (shipment.EndsWith("beers"))
            {
                amountOfBeers += Convert.ToInt32(numberBeers[0]);
            }
            else if (shipment.EndsWith("sixpacks"))
            {
                amountOfSixpacksBeers += Convert.ToInt32(numberBeers[0]);
            }
            else if (shipment.EndsWith("cases"))
            {
                amountOfCasesBeers += Convert.ToInt32(numberBeers[0]);
            }
        }

            // Calculate ordered beers
        long amountNeededBeers = amountOfBeers + (amountOfSixpacksBeers * 6) + (amountOfCasesBeers * 24);
        amountNeededBeers -= amountNeededBeers / 100;
            
            // Output
        long leftBeers = (long)Math.Abs(amountReservedBeers - amountNeededBeers);
        long casesLeft = leftBeers / 24;
        leftBeers %= 24;
        long sixpacksLeft = leftBeers / 6;
        leftBeers %= 6;

        if (amountNeededBeers >= amountReservedBeers)
        {
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, leftBeers);
        }
        else
        {
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, leftBeers);
        }
    }
}
