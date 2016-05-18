using System;

class SweetDessert
{
    static void Main()
    {
        double amountOfCash = double.Parse(Console.ReadLine());
        double numberOfGuests = double.Parse(Console.ReadLine());
        double priceBanana = double.Parse(Console.ReadLine());
        double priceEggs = double.Parse(Console.ReadLine());
        double priceBerries = double.Parse(Console.ReadLine());

        double setOfPortion = Math.Ceiling(numberOfGuests / 6.0);

        double neededProduct = (int)setOfPortion * (2 * priceBanana) + (int)setOfPortion * (4 * priceEggs) + (int)setOfPortion * (0.2 * priceBerries);

        if (amountOfCash - neededProduct < 0)
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", neededProduct - amountOfCash);
        }
        else
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", neededProduct);
        }
    }
}