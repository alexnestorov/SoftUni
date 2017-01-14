using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        // Input variables
        int albumsEU = int.Parse(Console.ReadLine());
        decimal priceEUR = decimal.Parse(Console.ReadLine());
        int albumsNA = int.Parse(Console.ReadLine());
        decimal priceUSD = decimal.Parse(Console.ReadLine());
        int albumsSA = int.Parse(Console.ReadLine());
        decimal pricePesos = decimal.Parse(Console.ReadLine());
        int concerts = int.Parse(Console.ReadLine());
        decimal profitPerConcert = decimal.Parse(Console.ReadLine());

        // Albums profit
        decimal albumsIncome = ((albumsEU * priceEUR) * 1.94m) + ((albumsNA * priceUSD) * 1.72m) + ((albumsSA * pricePesos) / 332.74m);
        decimal bandIncomeBT = (albumsIncome - (0.35m * albumsIncome));
        decimal bandIncome = bandIncomeBT - bandIncomeBT * 0.2m;
        
        // Concert pofit
        decimal concertProfit = (concerts * profitPerConcert) * 1.94m;
        if (concertProfit > 100000)
        {
            concertProfit = concertProfit - 0.15m * concertProfit;
        }
        
        //Output variables
        if (bandIncome > concertProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0}lv.", Math.Round(bandIncome,2));
        }
        else if (bandIncome <= concertProfit)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertProfit);
        }
    }
}
