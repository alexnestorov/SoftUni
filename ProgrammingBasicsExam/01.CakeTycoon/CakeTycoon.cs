using System;
using System.Linq;

class CakeTycoon
{
    static void Main()
    {
        // Input data
        ulong amountOfCakes = ulong.Parse(Console.ReadLine());
        double kgFlourPerCake = double.Parse(Console.ReadLine());
        int kgFlourAvailable = int.Parse(Console.ReadLine());
        ulong amountTruffles = ulong.Parse(Console.ReadLine());
        ulong pricePerTruffle = ulong.Parse(Console.ReadLine());

        // Calculate formula number of cakes, cake price and cost of truffles
        int numberOfCakes = (int)(kgFlourAvailable / kgFlourPerCake);
        decimal TrufflesCost = amountTruffles * pricePerTruffle;
        decimal cakePrice = (TrufflesCost / (int)amountOfCakes) * 1.25m;
        double kgFlourRequired = amountOfCakes * kgFlourPerCake;

        // Output
        if (numberOfCakes < (int)amountOfCakes)
        {
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", numberOfCakes, kgFlourRequired - kgFlourAvailable);
        }
        else
        {
            Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
        }
    }
}
