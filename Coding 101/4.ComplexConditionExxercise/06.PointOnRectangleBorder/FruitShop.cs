using System;

class FruitShop
{
    static void Main()
    {
        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine().ToLower());
        double price = 0.0;
        if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
        {
            if (fruit == "banana") price = 2.50 * quantity;
            if (fruit == "apple") price = 1.20 * quantity;
            if (fruit == "orange") price = 0.85 * quantity;
            if (fruit == "grapefruit") price = 1.45 * quantity;
            if (fruit == "kiwi") price = 2.70 * quantity;
            if (fruit == "pineapple") price = 5.50 * quantity;
            if (fruit == "grapes") price = 3.85 * quantity;
            if (price > 0) Console.WriteLine("{0:F2}", price);
            else Console.WriteLine("error");
        }
        else if (day == "saturday" || day == "sunday")
        {
            if (fruit == "banana") price = 2.70 * quantity;
            if (fruit == "apple") price = 1.25 * quantity;
            if (fruit == "orange") price = 0.90 * quantity;
            if (fruit == "grapefruit") price = 1.60 * quantity;
            if (fruit == "kiwi") price = 3.00 * quantity;
            if (fruit == "pineapple") price = 5.60 * quantity;
            if (fruit == "grapes") price = 4.20 * quantity;
            if (price > 0) Console.WriteLine("{0:F2}", price);
            else Console.WriteLine("error");
        }
        else Console.WriteLine("error");
    }
}
