using System;

class Shop
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine().ToLower());

        if (city == "sofia")
        {
            if (product == "coffee") Console.WriteLine(0.5*quantity);
            if (product == "water") Console.WriteLine(0.8 * quantity);
            if (product == "beer") Console.WriteLine(1.2 * quantity);
            if (product == "sweets") Console.WriteLine(1.45 * quantity);
            if (product == "peanuts") Console.WriteLine(1.6 * quantity);
        }
        else if (city == "plovdiv")
        {
            if (product == "coffee") Console.WriteLine(0.4 * quantity);
            if (product == "water") Console.WriteLine(0.7 * quantity);
            if (product == "beer") Console.WriteLine(1.15 * quantity);
            if (product == "sweets") Console.WriteLine(1.30 * quantity);
            if (product == "peanuts") Console.WriteLine(1.5 * quantity);
        }
        else if (city == "varna")
        {
            if (product == "coffee") Console.WriteLine(0.45 * quantity);
            if (product == "water") Console.WriteLine(0.7 * quantity);
            if (product == "beer") Console.WriteLine(1.1 * quantity);
            if (product == "sweets") Console.WriteLine(1.35 * quantity);
            if (product == "peanuts") Console.WriteLine(1.55 * quantity);
        }
    }
}
