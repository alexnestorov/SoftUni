using System;

class HungryGarfield
{
    static void Main()
    {
            // Input variables
        decimal moneyJohnDollars = decimal.Parse(Console.ReadLine());
        decimal exchangeRateDollars = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lazzanaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        ulong pizzaQuantity = ulong.Parse(Console.ReadLine());
        ulong lazzanaQuantity = ulong.Parse(Console.ReadLine());
        ulong sandwichQuantity = ulong.Parse(Console.ReadLine());

            // Calculation for money which are needed
        decimal pizzaValue = (pizzaPrice / exchangeRateDollars) * pizzaQuantity;
        decimal lazzanaValue = (lazzanaPrice / exchangeRateDollars) * lazzanaQuantity;
        decimal sandwichValue = (sandwichPrice / exchangeRateDollars) * sandwichQuantity;
        decimal moneyNeeded = pizzaValue + lazzanaValue + sandwichValue;

            // Output. Print result
        if (moneyNeeded < moneyJohnDollars)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", moneyJohnDollars - moneyNeeded);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", moneyNeeded - moneyJohnDollars );
        }
    }
}
